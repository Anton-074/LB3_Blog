
using LB3_Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace LB3_Blog
{
    public partial class FormMain : Form
    {
        //Создается экземпляр контекста данных, который будет использоваться для 
        //загрузки и отслеживания изменений о пльзователях
        private BlogContext? db;
        public FormMain()
        {
            InitializeComponent();
        }
        // Метод OnColad вызывается при загрузке формы
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new BlogContext();
            this.db.Users.Load();



            this.dataGridViewUsers.DataSource = this.db.Users.Local.ToBindingList();
        }
        //Метод вызыввается при закрытии формы
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void DataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (this.db != null)
            {
                var user = (User)this.dataGridViewUsers.CurrentRow.DataBoundItem;
                if (user != null)
                {
                    this.db.Entry(user).Collection(e => e.Posts).Load();
                    this.dataGridViewPosts.DataSource = user.Posts;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.db !. SaveChanges();
            this.dataGridViewUsers.Refresh();
            this.dataGridViewPosts.Refresh();
        }
    }
}
