namespace DoListy.Pages;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

public partial class YearPage : ContentPage
{
    Dictionary<DateTime, List<IView>> goalsList;
    public YearPage()
    {
        InitializeComponent();
        DateTime currentDate = DateTime.Now;
        yearLabel.Text = currentDate.Year.ToString();
        SetIniDisplayDate(currentDate);
        goalsList = new Dictionary<DateTime, List<IView>>(); // khi lam xong Database, goalsList se lay lai latest goalsList chu khong phai new

    }
    private void SetIniDisplayDate(DateTime currentDate)
    {
        janMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 1, 1);
        febMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 2, 1);
        marMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 3, 1);
        aprMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 4, 1);
        mayMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 5, 1);
        junMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 6, 1);
        julMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 7, 1);
        augMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 8, 1);
        sepMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 9, 1);
        octMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 10, 1);
        novMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 11, 1);
        decMonthViewCalendar.DisplayDate = new DateTime(currentDate.Year, 12, 1);

    }
    private void OnLeftArrowButtonClicked(object sender, EventArgs e)
    {
        yearLabel.Text = Convert.ToString(Convert.ToInt32(yearLabel.Text) - 1);
        ChangeYearOfDisplayDate(false);

        var currentDate = janMonthViewCalendar.DisplayDate;
        goalsListStack.Children.Clear();
        if (goalsList.ContainsKey(currentDate))
        {
            var numOfGoals = goalsList[currentDate].Count;
            for (int i = 0; i < numOfGoals; i++)
            {
                goalsListStack.Children.Add(goalsList[currentDate][i]);
            }
        }
    }
    private void OnRightArrowButtonClicked(object sender, EventArgs e)
    {
        yearLabel.Text = Convert.ToString(Convert.ToInt32(yearLabel.Text) + 1);
        ChangeYearOfDisplayDate(true);

        var currentDate = janMonthViewCalendar.DisplayDate;
        goalsListStack.Children.Clear();
        if (goalsList.ContainsKey(currentDate))
        {
            var numOfGoals = goalsList[currentDate].Count;
            for (int i = 0; i < numOfGoals; i++)
            {
                goalsListStack.Children.Add(goalsList[currentDate][i]);
            }
        }
    }
    private void ChangeYearOfDisplayDate(bool plus)
    {
        int num;
        if (plus) num = 1;
        else num = -1;
        janMonthViewCalendar.DisplayDate = janMonthViewCalendar.DisplayDate.AddYears(num);
        febMonthViewCalendar.DisplayDate = febMonthViewCalendar.DisplayDate.AddYears(num);
        marMonthViewCalendar.DisplayDate = marMonthViewCalendar.DisplayDate.AddYears(num);
        aprMonthViewCalendar.DisplayDate = aprMonthViewCalendar.DisplayDate.AddYears(num);
        mayMonthViewCalendar.DisplayDate = mayMonthViewCalendar.DisplayDate.AddYears(num);
        junMonthViewCalendar.DisplayDate = junMonthViewCalendar.DisplayDate.AddYears(num);
        julMonthViewCalendar.DisplayDate = julMonthViewCalendar.DisplayDate.AddYears(num);
        augMonthViewCalendar.DisplayDate = augMonthViewCalendar.DisplayDate.AddYears(num);
        sepMonthViewCalendar.DisplayDate = sepMonthViewCalendar.DisplayDate.AddYears(num);
        octMonthViewCalendar.DisplayDate = octMonthViewCalendar.DisplayDate.AddYears(num);
        novMonthViewCalendar.DisplayDate = novMonthViewCalendar.DisplayDate.AddYears(num);
        decMonthViewCalendar.DisplayDate = decMonthViewCalendar.DisplayDate.AddYears(num);
    }

    private async void OnJanButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = janMonthViewCalendar.DisplayDate;
    }
    private async void OnFebButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = febMonthViewCalendar.DisplayDate;
    }
    private async void OnMarButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = marMonthViewCalendar.DisplayDate;
    }
    private async void OnAprButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = aprMonthViewCalendar.DisplayDate;
    }
    private async void OnMayButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = mayMonthViewCalendar.DisplayDate;
    }
    private async void OnJunButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = junMonthViewCalendar.DisplayDate;
    }
    private async void OnJulButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = julMonthViewCalendar.DisplayDate;
    }
    private async void OnAugButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = augMonthViewCalendar.DisplayDate;
    }
    private async void OnSepButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = sepMonthViewCalendar.DisplayDate;
    }
    private async void OnOctButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = octMonthViewCalendar.DisplayDate;
    }
    private async void OnNovButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = novMonthViewCalendar.DisplayDate;
    }
    private async void OnDecButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Month");
        var monthPage = (MonthPage)Shell.Current.CurrentPage;
        monthPage.Scheduler.DisplayDate = decMonthViewCalendar.DisplayDate;
    }

    private void OnGoalsPlusButtonClicked(object sender, EventArgs e)
    {
        var newGoal = new Label
        {
            Text = "A Goal in " + janMonthViewCalendar.DisplayDate.ToString()
        };
        var currentdate = janMonthViewCalendar.DisplayDate;
        if (goalsList.ContainsKey(currentdate))
        {
            goalsList[currentdate].Add(newGoal);
        }
        else
        {
            var newGoalList = new List<IView>();
            newGoalList.Add(newGoal);
            goalsList.Add(currentdate, newGoalList);
        }
        goalsListStack.Children.Add(newGoal);
    }
}


