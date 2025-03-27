using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms2.DAL;
using WindowsForms2.BLL;
using WindowsForms2.exception;
using WindowsForms2.CustomComponent;

namespace WindowsForms2.FORM
{
    public partial class fProduct: Form
    {
        private ProductBLL _productBLL;
        private Product_sizeBLL _product_SizeBLL;
        private CategoryBLL _categoryBLL;
        private CollectionBLL _collectionBLL;
        private Attribute_valueBLL _attribute_ValueBLL;
        public fProduct()
        {
            InitializeComponent();
            _productBLL = ProductBLL.Instance;
            _product_SizeBLL = Product_sizeBLL.Instance;
            _categoryBLL = CategoryBLL.Instance;
            _collectionBLL = CollectionBLL.Instance;
            _attribute_ValueBLL = Attribute_valueBLL.Instance;
            LoadProduct();
        }

        private void LoadProduct()
        {
            dgvSp.DataSource = _productBLL.GetProducts().Select(p => new
            {
                p.id,
                p.title,
                p.material,
                category = p.category != null ? p.category.name : null,
                collection = p.collection != null ? p.collection.name : null,
                p.status,
                p.created_at,
                p.updated_at
            }).ToList();
            dgvSp.Columns["id"].Width = 40;
            dgvSp.Columns["title"].Width = 330;
            dgvSp.Columns["material"].Width = 70;
            dgvSp.Columns["category"].Width = 90;
            dgvSp.Columns["collection"].Width = 90;
            dgvSp.Columns["status"].Width = 100;
            dgvSp.Columns["created_at"].Width = 100;
            dgvSp.Columns["updated_at"].Width = 100;
        }

        private void dgvSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSp.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["id"].Value);
                productNameTxtBox.Texts = row.Cells["title"].Value.ToString();
                materialTxtBox.Texts = row.Cells["material"].Value.ToString();
                categoryCbbox.DataSource = _categoryBLL.GetCategories().Select(c => c.name).ToList();
                collectionCbbox.DataSource = _collectionBLL.GetCollections().Select(c => c.name).ToList();
                statusCbbox.DataSource = new List<string> { "IN_STOCK", "OUT_OF_STOCK" };
                categoryCbbox.Texts = row.Cells["category"].Value?.ToString() ?? string.Empty;
                collectionCbbox.Texts = row.Cells["collection"].Value?.ToString() ?? string.Empty;
                statusCbbox.Texts = row.Cells["status"].Value.ToString();
                List<attribute_value> productAttributes = _productBLL.findById(productId).attribute_value.ToList();
                CustomButton button = addAttributeBtn;
                flpAttribute.Controls.Clear();
                foreach (attribute_value pa in productAttributes)
                {
                    AttributeShow attributeShow = new AttributeShow();
                    attributeShow.attributeValueTxtBox.Texts = pa.value;
                    attributeShow.attributeNameTxtBox.Texts = pa.attribute.name;
                    Button deleteBtn = createAttrDeleteBtn(flpAttribute, attributeShow);
                    flpAttribute.Controls.Add(attributeShow);
                    flpAttribute.Controls.Add(deleteBtn);
                }
                flpAttribute.Controls.Add(button);
                productInfoPanel.Visible = true;
            } 
        }

        private void addAttributeBtn_Click(object sender, EventArgs e)
        {
            AttributeShow attributeShow = new AttributeShow();
            CustomButton button = addAttributeBtn;
            flpAttribute.Controls.Remove(button);
            Button deleteBtn = createAttrDeleteBtn(flpAttribute, attributeShow);
            flpAttribute.Controls.Add(attributeShow);
            flpAttribute.Controls.Add(deleteBtn);
            flpAttribute.Controls.Add(button);
        }

        private Button createAttrDeleteBtn(FlowLayoutPanel flowLayoutPanel, AttributeShow attributeShow)
        {
            Button deleteBtn = new Button();
            deleteBtn.BackgroundImage = Properties.Resources.delete;
            deleteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            deleteBtn.Size = new Size(32, 32);
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.Margin = new Padding(0, 20, 10, 0);
            deleteBtn.Click += (btn, ev) =>
            {
                flowLayoutPanel.Controls.Remove(attributeShow);
                flowLayoutPanel.Controls.Remove(deleteBtn);
            };
            return deleteBtn;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            productInfoPanel.Visible = false;
        }

        private void manageSizeBtn_Click(object sender, EventArgs e)
        {
            string title = productNameTxtBox.Texts;
            try
            {
                product p = _productBLL.findByTitle(title);
                fSize fSize = new fSize(p.id);
                using (fBlur f = new fBlur(JewelryManagementApp.ActiveForm))
                {
                    f.Show();
                    fSize.ShowDialog();
                    f.Close();
                }
            }
            catch (ResourceNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            fAddProduct fAddProduct = new fAddProduct();
            using (fBlur fBlur = new fBlur(JewelryManagementApp.ActiveForm))
            {
                fBlur.Show();
                fAddProduct.ShowDialog();
                fBlur.Close();
            }
        }
    }
}
