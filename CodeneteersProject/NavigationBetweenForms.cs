using CodeNETeersProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeneteersProject
{
    public class NavigationBetweenForms
    {
        DashboardForm dashboardForm = new DashboardForm();
        ProfilForm profileForm = new ProfilForm();

        CompaniesForm companiesForm = new CompaniesForm();
        AdvertisementsAndEventsForm advertisementsAndEventsForm = new AdvertisementsAndEventsForm();
        JobAdvertisementsForm jobAdvertisementsForm = new JobAdvertisementsForm();
        WishAndSuggestionForm wishAndSuggestionForm = new WishAndSuggestionForm();
        LoginForm loginForm = new LoginForm();



        public NavigationBetweenForms()
        {
        }

        public void GoToDashboard(Form form)
        {
            form.Hide();
            form.Visible = false;
            dashboardForm.Show();
        }

        public void GoToProfile(Form form)
        {
            form.Hide();
            form.Visible = false;
            profileForm.Show();
        }

        public void GoToLogin(Form form)
        {
        form.Hide();
        form.Visible = false;
        loginForm.Show();
        }

        public void GoToCompanies(Form form)
        {
        form.Hide();
        form.Visible = false;
        companiesForm.Show();
        }

        public void GoToAdds(Form form)
        {
        form.Hide();
        form.Visible = false;
        advertisementsAndEventsForm.Show();
        }

        public void GoToJobAdds(Form form)
        {
        
        form.Hide();
        form.Visible = false;
        jobAdvertisementsForm.Show();
        }

        public void GoToWishes(Form form)
        {
        
        form.Hide();
        form.Visible = false;
        wishAndSuggestionForm.Show();
        }


    }
}
