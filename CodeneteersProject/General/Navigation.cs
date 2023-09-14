using CodeneteersProject.HR;
using CodeNETeersProject;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeneteersProject.General
{
    public static class NavigationHelper
    {
        static public void JobAdvertisementsFormNavigation(User appUser)
        {
            JobAdvertisementsForm appUserForm = new JobAdvertisementsForm(appUser);
            appUserForm.Show();
        }

        static public void DashboardFormNavigation(User appUser)
        {
            DashboardForm dashboardForm = new DashboardForm(appUser);
            dashboardForm.Show();
        }

        static public void ProfileFormNavigation(User appUser)
        {
            ProfilForm profilForm = new ProfilForm(appUser);
            profilForm.Show();
        }

        static public void RestFormNavigation(User appUser)
        {
            RestForm restForm = new RestForm(appUser);
            restForm.Show();
        }

        static public void CompaniesFormNavigation(User appUser)
        {
            CompaniesForm companiesForm = new CompaniesForm(appUser);
            companiesForm.Show();
        }

        static public void AdvertisementsAndEventsFormNavigation(User appUser)
        {
            AdvertisementsAndEventsForm advertisementsAndEventsForm = new AdvertisementsAndEventsForm(appUser);
            advertisementsAndEventsForm.Show();
        }

        static public void AdvertisementAndEventDetailFormNavigation(User appUser)
        {
            AdvertisementAndEventDetailForm advertisementAndEventDetailForm = new AdvertisementAndEventDetailForm(appUser);
            advertisementAndEventDetailForm.Show();
        }

        static public void WishAndSuggestionFormNavigation(User appUser)
        {
            WishAndSuggestionForm wishAndSuggestionForm = new WishAndSuggestionForm(appUser);
            wishAndSuggestionForm.Show();
        }

        static public void BordroFormNavigation(User appUser)
        {
            BordroForm BordroForm= new BordroForm(appUser);
            BordroForm.Show();
        }

        static public void RestHomeNavigation(User appUser)
        {
            RestHomeForm restHomeForm = new RestHomeForm(appUser);
            restHomeForm.Show();
        }

        static public void hrDashBoarNavigation(User appUser)
        {
            hrDashBoardForm hrDashBoardForm = new hrDashBoardForm(appUser);
            hrDashBoardForm.Show();
        }

        static public void hrProfileFormNavigation(User appUser)
        {
            ProfileForm profileForm = new ProfileForm(appUser);
            profileForm.Show();
        }

        static public void hrPersonalManagmentFormNavigation(User appUser)
        {
            PersonalManagmentForm personalManagmentForm = new PersonalManagmentForm();
            personalManagmentForm.Show();
        }

        static public void hrAddsAndEventsFormNavigation(User appUser)
        {
            AddsAndEventsForm addsAndEventsForm = new AddsAndEventsForm(appUser);
            addsAndEventsForm.Show();
        }

        static public void hrJobAddsManagementFormNavigation(User appUser)
        {
            JobAddsManagementForm jobAddsManagementForm = new JobAddsManagementForm(appUser);
            jobAddsManagementForm.Show();
        }

        static public void hrReadWishFormNavigation(User appUser)
        {
            ReadWishForm ReadWishForm = new ReadWishForm(appUser);
            ReadWishForm.Show();
        }
        
    }
}
