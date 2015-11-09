using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Images;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Domain.Entities.Comments;
using Comment = Domain.Entities.Comments.Comment;
using Domain.Entities.Users;

namespace ContosoUI.ProductForm
{
    public partial class ProductView : DevExpress.XtraBars.Ribbon.RibbonForm, IProductView
    {
        private ProductPresenter _presenter;
        private BindingSource _binding;

        public ProductView()
        {
            InitializeComponent();
            _presenter = new ProductPresenter(this, new ProductModel());
        }

        public ProductView(int id)
        {
            InitializeComponent();
            _presenter = new ProductPresenter(this, new ProductModel());
            _presenter.UseProductWithID(id);
        }

        private void ProductAddView_Load(object sender, EventArgs e)
        {
            BindControls();
            ShowDependentOnRole(Program.AuthUser.Role);
        }

        private void BindControls()
        {
            _binding = new BindingSource() { DataSource = _presenter};

            productSKUTextEdit.DataBindings.Add("EditValue", _binding, "SKU");
            productTitleTextEdit.DataBindings.Add("EditValue", _binding, "Title");
            productQuantitySpinEdit.DataBindings.Add("Value", _binding, "Quantity");
            productPriceTextEdit.DataBindings.Add("EditValue", _binding, "Price");

            productCategoryTextEdit.DataBindings.Add("EditValue", _binding, "Category");
            categorySearchControl.DataBindings.Add("EditValue", _binding, "SearchTitleCategory");
            productCommentsListBoxControl.DataBindings.Add("DataSource", _binding, "ProductComments");
            categoryGridControl.DataBindings.Add("DataSource", _binding, "Categories");
            SetStateButtonState();
        }

        private void ShowDependentOnRole(Role role)
        {
            if (!role.Permissions.Any(x => x.Title == "Edit Product"))
            {
                barSaveButton.Visibility = BarItemVisibility.Never;
                barSaveAndNewButton.Visibility = BarItemVisibility.Never;
                barNewButton.Visibility = BarItemVisibility.Never;
            }
            if (!role.Permissions.Any(x => x.Title == "Activate Product"))
            {
                productStateButton.Visibility = BarItemVisibility.Never;
            }
            if (!role.Permissions.Any(x => x.Title == "Deactivate Product"))
            {
                productStateButton.Visibility = BarItemVisibility.Never;
            }
            if (!role.Permissions.Any(x => x.Title == "Comment Product"))
            {
                newCommentTextBox.Enabled = false;
                addCommentButton.Enabled = false;
            }
        }

        public void ShowView()
        {
            Show();
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newCommentTextBox.Text))
            {
                Comment comment = new Comment() { Author = Program.AuthUser, EntityType = EntityType.Product, Text = newCommentTextBox.Text };
                _presenter.ProductComments.Add(comment);
                newCommentTextBox.Text = string.Empty;
                _presenter.Save();
            }
        }
        
        private void categorySearchControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            _binding.EndEdit();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrWhiteSpace(categorySearchControl.Text))
                    _presenter.Search();
                else
                {
                    _presenter.AllCategoriesToGrid();
                }
            }
        }

        private void categoryGridView_RowClick(object sender, RowClickEventArgs e)
        {
            categoryCommentsListBoxControl.DataBindings.Clear();
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (e.HitInfo.InRow || e.HitInfo.InColumn)
            {
                int id = (int)view.GetRowCellValue(info.RowHandle, "Id");
                _presenter.UseCategoryWithID(id);
                categoryCommentsListBoxControl.DataBindings.Add("DataSource", _binding, "CategoryComments");
            }
        }

        private void barSaveButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _binding.EndEdit();
            if (!IsControlsEmpty())
                _presenter.Save();
            else
                MessageBox.Show("Fill infromation about product before saving", "Attention", MessageBoxButtons.OK);
        }

        private bool IsControlsEmpty()
        {
            return string.IsNullOrEmpty(productSKUTextEdit.Text) || string.IsNullOrEmpty(productTitleTextEdit.Text) || string.IsNullOrEmpty(productPriceTextEdit.Text) || productCategoryTextEdit.EditValue == null;
        }

        private void barSaveAndNewButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _binding.EndEdit();
            _presenter.Save();
            _presenter.New();
        }

        private void barNewButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _presenter.New();
        }

        private void newCommentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                addCommentButton_Click(this, e);
            }
        }

        private void categoryGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            categoryCommentsListBoxControl.DataBindings.Clear();
            GridView view = (GridView)sender;

            int id = (int)view.GetRowCellValue(e.FocusedRowHandle, "Id");
            _presenter.UseCategoryWithID(id);
            categoryCommentsListBoxControl.DataBindings.Add("DataSource", _binding, "CategoryComments");
            _binding.EndEdit();
       }
 
        private void productStateButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _presenter.IsActive = !_presenter.IsActive;
            SetStateButtonState();
        }
        private void SetStateButtonState()
        {
            if (_presenter.IsActive)
            {
                productStateButton.Caption = "Remove";
                productStateButton.LargeGlyph = ImageResourceCache.Default.GetImage("images/edit/delete_32x32.png");
            }
            else
            {
                productStateButton.Caption = "Activate";
                productStateButton.LargeGlyph = ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png");
            }
        }

        private void ProductView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _presenter.Stop();
        }
    }
}