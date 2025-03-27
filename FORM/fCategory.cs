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
using System.Data.Entity;

namespace WindowsForms2.FORM
{
    public partial class fCategory: Form
    {
        private CategoryBLL _categoryBLL;
        private CollectionBLL _collectionBLL;
        public fCategory()
        {
            _categoryBLL = CategoryBLL.Instance;
            _collectionBLL = CollectionBLL.Instance;
            InitializeComponent();
            LoadCategory();
            LoadCollection();
        }

        private void LoadCategory() 
        {
            dgvCate.Rows.Clear();
            _categoryBLL.GetCategories().Select(c => new
            {
                c.id,
                c.name,
                c.parent_id,
                parent_name = c.parent_id != null ? c.category2.name : null
            }).ToList().ForEach((category) =>
            {
                dgvCate.Rows.Add(category.id, category.name, category.parent_id, category.parent_name);
            });
        }

        private void LoadCollection()
        {
            dgvCollection.Rows.Clear();
            _collectionBLL.GetCollections().Select(c => new
            {
                c.id,
                c.name,
                c.description,
            }).ToList().ForEach((collection) =>
            {
                dgvCollection.Rows.Add(collection.id, collection.name, collection.description);
            } );
        }

        private void dgvCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvCate.Rows[e.RowIndex];
                    cateTxtBox.Texts = row.Cells["name"].Value.ToString();
                    parentCateCbbox.DataSource = _categoryBLL.GetCategories().Select(c => c.name).ToList();
                    parentCateCbbox.Texts = row.Cells["parent_name"].Value?.ToString() ?? string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void dgvCollection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvCollection.Rows[e.RowIndex];
                    collectionNameTxtBox.Texts = row.Cells["collection_name"].Value.ToString();
                    collectionDesTxtBox.Texts = row.Cells["description"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!");
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
