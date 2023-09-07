using BusinessLayer.Concrete;
using Guna.UI2.WinForms;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;

namespace CodeneteersProject
{
    public partial class AdvertisementsAndEventsForm : Form
    {

        private Guna2Button postLoopButton;
        string EventPostType = "event";
        string AdvertisementPostType = "advertisement";

        bool scroll = false;
        PostsManager postsManager = new PostsManager(new PostsDAL());

        private int GetPostIdFromButtonName(string buttonName)
        {
            string temporary = string.Empty;
            int id;

            for (int i = 0; i < buttonName.Length; i++)
            {
                if (Char.IsDigit(buttonName[i]))
                    temporary += buttonName[i];
            }
            if (temporary.Length > 0)
            {
                id = int.Parse(temporary);
                return id;
            }
            else
            {
                return 0;
            }

        }

        private void GoToDetailPage(Posts post)
        {
            AdvertisementAndEventDetailForm advertisementAndEventDetailForm = new AdvertisementAndEventDetailForm(post);
            this.Hide();
            advertisementAndEventDetailForm.ShowDialog();

        }


        private List<Posts> PickedPosts(List<Posts> allPosts, string postType)
        {
            List<Posts> pickedPostsFromType = new List<Posts>();
            foreach (Posts post in allPosts)
            {
                if (post.type == postType)
                    pickedPostsFromType.Add(post);
            }
            return pickedPostsFromType;
        }

        private void drawPostButton(int id, int yCoordinate, string title, Panel panel)
        {
            Guna2Button postLoopButton = new Guna2Button();

            panel.Controls.Add(postLoopButton);
            postLoopButton.BackColor = Color.Transparent;
            postLoopButton.BorderColor = SystemColors.ControlDark;
            postLoopButton.DisabledState.BorderColor = Color.DarkGray;
            postLoopButton.DisabledState.CustomBorderColor = Color.DarkGray;
            postLoopButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            postLoopButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            postLoopButton.FillColor = Color.Transparent;
            postLoopButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            postLoopButton.ForeColor = Color.White;
            postLoopButton.ImageAlign = HorizontalAlignment.Left;
            postLoopButton.Location = new Point(30, yCoordinate);
            postLoopButton.Margin = new Padding(3, 4, 3, 4);
            postLoopButton.Name = "advertisementButton" + id.ToString();
            postLoopButton.Size = new Size(216, 46);
            postLoopButton.TabIndex = 0;
            postLoopButton.Text = title;
            postLoopButton.TextAlign = HorizontalAlignment.Left;
            postLoopButton.Click += PostLoopButton_Click;
            yCoordinate += 50;
        }



        public AdvertisementsAndEventsForm()
        {
            InitializeComponent();
            scrollBar.Value = shdwpanel1.VerticalScroll.Value;
            scrollBar.Minimum = shdwpanel1.VerticalScroll.Minimum;
            scrollBar.Maximum = shdwpanel1.VerticalScroll.Maximum;
            shdwpanel1.ControlAdded += Shdwpanel1_ControlAdded;

        }

        private void Shdwpanel1_ControlAdded(object? sender, ControlEventArgs e)
        {

            scrollBar.Maximum = shdwpanel1.VerticalScroll.Maximum;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void AdvertisementsForm_Load(object sender, EventArgs e)
        {

            List<Posts> postsList = postsManager.list();
            List<Posts> advertisementsList = PickedPosts(postsList, AdvertisementPostType);
            List<Posts> eventsList = PickedPosts(postsList, EventPostType);

            int yCoordinate = 20;

            foreach (Posts advertisement in advertisementsList)
            {
                postLoopButton = new Guna.UI2.WinForms.Guna2Button();
                //drawPostButton(postLoopButton ,advertisement.ID, x, advertisement.title, shdwpanel1);
                shdwpanel1.Controls.Add(postLoopButton);
                postLoopButton.BackColor = Color.Transparent;
                postLoopButton.BorderColor = SystemColors.ControlDark;
                postLoopButton.DisabledState.BorderColor = Color.DarkGray;
                postLoopButton.DisabledState.CustomBorderColor = Color.DarkGray;
                postLoopButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                postLoopButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
                postLoopButton.FillColor = Color.Transparent;
                postLoopButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                postLoopButton.ForeColor = Color.White;
                postLoopButton.ImageAlign = HorizontalAlignment.Left;
                postLoopButton.Location = new Point(30, yCoordinate);
                postLoopButton.Margin = new Padding(3, 4, 3, 4);
                postLoopButton.Name = "advertisementButton" + advertisement.ID.ToString();
                postLoopButton.Size = new Size(310, 46);
                postLoopButton.TabIndex = 0;
                postLoopButton.Text = advertisement.title;
                postLoopButton.TextAlign = HorizontalAlignment.Left;
                postLoopButton.Click += PostLoopButton_Click;
                yCoordinate += 50;

            }
            yCoordinate = 20;
            foreach (Posts events in eventsList)
            {
                postLoopButton = new Guna.UI2.WinForms.Guna2Button();
                //drawPostButton(events.ID, x, events.title, panel2);
                panel2.Controls.Add(postLoopButton);
                postLoopButton.BackColor = Color.Transparent;
                postLoopButton.BorderColor = SystemColors.ControlDark;
                postLoopButton.DisabledState.BorderColor = Color.DarkGray;
                postLoopButton.DisabledState.CustomBorderColor = Color.DarkGray;
                postLoopButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                postLoopButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
                postLoopButton.FillColor = Color.Transparent;
                postLoopButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                postLoopButton.ForeColor = Color.White;
                postLoopButton.ImageAlign = HorizontalAlignment.Left;
                postLoopButton.Location = new Point(30, yCoordinate);
                postLoopButton.Margin = new Padding(3, 4, 3, 4);
                postLoopButton.Name = "advertisementButton" + events.ID.ToString();
                postLoopButton.Size = new Size(310, 46);
                postLoopButton.TabIndex = 0;
                postLoopButton.Text = events.title;
                postLoopButton.TextAlign = HorizontalAlignment.Left;
                postLoopButton.Click += PostLoopButton_Click;
                yCoordinate += 50;

            }
        }


        private void PostLoopButton_Click(object? sender, EventArgs e)
        {
            Guna2Button postButton = sender as Guna2Button;
            int postID = GetPostIdFromButtonName(postButton.Name);
            Posts post = postsManager.GetByID(postID);
            GoToDetailPage(post);
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {

            shdwpanel1.VerticalScroll.Value = scrollBar.Value;

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void scrollBar_Scroll_1(object sender, ScrollEventArgs e)
        {

        }


    }
}
