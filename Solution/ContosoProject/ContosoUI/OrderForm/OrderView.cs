using DevExpress.XtraGrid.Views.Grid;
using Domain.Entities.Orders;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Images;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Domain.Entities.Comments;
using Domain.Entities.Products;
using Domain.Entities.Users;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;

namespace ContosoUI.OrderForm
{
    public partial class OrderForm : DevExpress.XtraBars.Ribbon.RibbonForm, IOrderView
    {
        private OrderPresenter _presenter;
        private BindingSource binding;

        public OrderForm()
        {
            InitializeComponent();
            _presenter = new OrderPresenter(new OrderModel(), this);
        }

        public OrderForm(int id)
        {
            InitializeComponent();
            _presenter = new OrderPresenter(new OrderModel(), this);
            _presenter.UseOrderWithID(id);
        }

        private void OrderViewList_Load(object sender, EventArgs e)
        {
            ShowDependentOnRole(Program.AuthUser.Role);

            repositoryQuantitySpinEdit.Validating += RepositoryQuantitySpinEditOnValidating;
            binding = new BindingSource {DataSource = _presenter};

            clientLookUpEdit.Properties.DataSource = _presenter.ClientsList;
            clientLookUpEdit.DataBindings.Add("EditValue", binding, "ClientID");
            clientLookUpEdit.Properties.ValueMember = "Id";
            clientLookUpEdit.Properties.DisplayMember = "Person";

            orderStatusLookUpEdit.Properties.DataSource = _presenter.StatusEnum;
            orderStatusLookUpEdit.DataBindings.Add("EditValue", binding, "Status");
            orderNumberTextEdit.DataBindings.Add("EditValue", binding, "OrderNumber");

            orderDateEdit.DataBindings.Add("EditValue", binding, "Date");
            orderGridControl.DataBindings.Add("DataSource", binding, "OrderItems");
            commentsListBox.DataBindings.Add("DataSource", binding, "Comments");
            totalPriceTextEdit.DataBindings.Add("EditValue", binding, "TotalPrice");

            orderRepositoryProductLookUpEdit.DataSource = _presenter.Products;
            SetStateButtonState();

            SetActivityOfComments();
        }

        private void ShowDependentOnRole(Role role)
        {
            if (!role.Permissions.Any(x => x.Title == "Edit Order"))
            {
                orderSaveBarButton.Visibility = BarItemVisibility.Never;
                orderSaveAndNewBarButton.Visibility = BarItemVisibility.Never;
                ClearBarButton.Visibility = BarItemVisibility.Never;
                addOrderItemButton.Visibility = BarItemVisibility.Never;
            }
            if (!role.Permissions.Any(x => x.Title == "Activate Order"))
            {
                barStateButton.Visibility = BarItemVisibility.Never;
            }
            if (!role.Permissions.Any(x => x.Title == "Deactivate Order"))
            {
                barStateButton.Visibility = BarItemVisibility.Never;
            }
            if (!role.Permissions.Any(x => x.Title == "Comment Order"))
            {
                newCommentTextBox.Enabled = false;
                addCommentButton.Enabled = false;
            }
        }

        private void RepositoryQuantitySpinEditOnValidating(object sender, CancelEventArgs e)
        {

        }

        private void SetActivityOfComments()
        {
            if (orderNumberTextEdit.Text == string.Empty)
            {
                commentsListBox.Enabled = false;
                newCommentTextBox.Enabled = false;
                addCommentButton.Enabled = false;
            }
            else
            {
                commentsListBox.Enabled = true;
                newCommentTextBox.Enabled = true;
                addCommentButton.Enabled = true;
            }
        }

        private void orderSaveBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            binding.EndEdit();
            _presenter.Save();
        }

        private void orderSaveAndNewBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            binding.EndEdit();
            _presenter.SaveAndNew();
        }

        private void ClearBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.New();
        }

        public void ShowView()
        {
            Show();
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newCommentTextBox.Text))
            {
                Comment comment = new Comment() {Author = Program.AuthUser, EntityType = EntityType.Order, Text = newCommentTextBox.Text};
                _presenter.Comments.Add(comment);
                newCommentTextBox.Text = string.Empty;
                _presenter.Save();
            }
        }

        private void orderNumberTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetActivityOfComments();
        }

        private void barStateButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.State = !_presenter.State;
            SetStateButtonState();
        }

        private void SetStateButtonState()
        {
            if (_presenter.State)
            {
                barStateButton.Caption = "Remove";
                barStateButton.LargeGlyph = ImageResourceCache.Default.GetImage("images/edit/delete_32x32.png");
            }
            else
            {
                barStateButton.Caption = "Activate";
                barStateButton.LargeGlyph = ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png");
            }
        }

        private void addOrderItemButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.OrderItems.Add(new OrderItem(new Product() {Title = "Choose product"}, 0, 0));
        }

        private void orderGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var view = sender as GridView;

            if (e.Column == colQuantity || e.Column == colProduct)
            {
                var product = (view.GetRowCellValue(e.RowHandle, "Product") as Product);
                int quantity = (int)view.GetRowCellValue(e.RowHandle, "Quantity");
                if (product != null)
                {
                    _presenter.OrderItems.Remove(_presenter.OrderItems.FirstOrDefault(x => x.Product.Title == product.Title));
                    _presenter.OrderItems.Add(new OrderItem(product, quantity, product.Price));                    
                    repositoryQuantitySpinEdit.MaxValue = product.Quantity;
                    _presenter.OrderItemsComparer();
                    _presenter.TotalPrice = _presenter.OrderItems.Sum(x => x.Price * x.Quantity);
                }
            }
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _presenter.Stop();
        }
    }
}