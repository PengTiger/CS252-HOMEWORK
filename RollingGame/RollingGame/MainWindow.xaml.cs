using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RollingGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Str = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ChoseCat_Checked(object sender, RoutedEventArgs e)
        {
            Pet.Visibility = Visibility.Hidden;
            ChoseDog.Visibility = Visibility.Hidden;
            ChoseCat.Visibility = Visibility.Hidden;
            ChoseTiger.Visibility = Visibility.Hidden;
            ChoseAnt.Visibility = Visibility.Hidden;
            Habit.Visibility = Visibility.Visible;
            ChoseEat.Visibility = Visibility.Visible;
            ChoseShopping.Visibility = Visibility.Visible;
            ChoseChimb.Visibility = Visibility.Visible;
            ChoseSleep.Visibility = Visibility.Visible;
            ChoseEat.Content = "唱歌";
            ChoseShopping.Content = "跳舞";
            ChoseChimb.Content = "健行";
            ChoseSleep.Content = "看書";
            Str += "你選擇的選像包含→喜歡寵物：貓、";
        }

        public void ChoseTiger_Checked(object sender, RoutedEventArgs e)
        {
            Pet.Visibility = Visibility.Hidden;
            ChoseDog.Visibility = Visibility.Hidden;
            ChoseCat.Visibility = Visibility.Hidden;
            ChoseTiger.Visibility = Visibility.Hidden;
            ChoseAnt.Visibility = Visibility.Hidden;
            Habit.Visibility = Visibility.Visible;
            ChoseEat.Visibility = Visibility.Visible;
            ChoseShopping.Visibility = Visibility.Visible;
            ChoseChimb.Visibility = Visibility.Visible;
            ChoseSleep.Visibility = Visibility.Visible;
            ChoseEat.Content = "書法";
            ChoseShopping.Content = "下棋";
            ChoseChimb.Content = "旅遊";
            ChoseSleep.Content = "改車";
            Str += "你選擇的選像包含→喜歡寵物：虎、";
        }

        public void ChoseAnt_Checked(object sender, RoutedEventArgs e)
        {
            Pet.Visibility = Visibility.Hidden;
            ChoseDog.Visibility = Visibility.Hidden;
            ChoseCat.Visibility = Visibility.Hidden;
            ChoseTiger.Visibility = Visibility.Hidden;
            ChoseAnt.Visibility = Visibility.Hidden;
            Habit.Visibility = Visibility.Visible;
            ChoseEat.Visibility = Visibility.Visible;
            ChoseShopping.Visibility = Visibility.Visible;
            ChoseChimb.Visibility = Visibility.Visible;
            ChoseSleep.Visibility = Visibility.Visible;
            ChoseEat.Content = "跳繩";
            ChoseShopping.Content = "游泳";
            ChoseChimb.Content = "慢跑";
            ChoseSleep.Content = "健身";
            Str += "你選擇的選像包含→喜歡寵物：螞蟻、";
        }

        public void ChoseDog_Checked(object sender, RoutedEventArgs e)
        {
            Pet.Visibility = Visibility.Hidden;
            ChoseDog.Visibility = Visibility.Hidden;
            ChoseCat.Visibility = Visibility.Hidden;
            ChoseTiger.Visibility = Visibility.Hidden;
            ChoseAnt.Visibility = Visibility.Hidden;
            Habit.Visibility = Visibility.Visible;
            ChoseEat.Visibility = Visibility.Visible;
            ChoseShopping.Visibility = Visibility.Visible;
            ChoseChimb.Visibility = Visibility.Visible;
            ChoseSleep.Visibility = Visibility.Visible;
            Str += "你選擇的選像包含→喜歡寵物：狗、";
        }

        public void ChoseEat_Checked(object sender, RoutedEventArgs e)
        {
            Habit.Visibility = Visibility.Hidden;
            ChoseEat.Visibility = Visibility.Hidden;
            ChoseShopping.Visibility = Visibility.Hidden;
            ChoseChimb.Visibility = Visibility.Hidden;
            ChoseSleep.Visibility = Visibility.Hidden;
            ChoseGender.Visibility = Visibility.Visible;
            Male.Visibility = Visibility.Visible;
            Female.Visibility = Visibility.Visible;
            Secret.Visibility = Visibility.Visible;
            Str += "你的興趣：" + ChoseEat.Content.ToString() + "、";
        }

        public void ChoseShopping_Checked(object sender, RoutedEventArgs e)
        {
            Habit.Visibility = Visibility.Hidden;
            ChoseEat.Visibility = Visibility.Hidden;
            ChoseShopping.Visibility = Visibility.Hidden;
            ChoseChimb.Visibility = Visibility.Hidden;
            ChoseSleep.Visibility = Visibility.Hidden;
            ChoseGender.Visibility = Visibility.Visible;
            Male.Visibility = Visibility.Visible;
            Female.Visibility = Visibility.Visible;
            Secret.Visibility = Visibility.Visible;
            ChoseGender.Content = "如果有機會選擇你希望你的性別";
            Str += "你的興趣：" + ChoseShopping.Content.ToString() + "、";
        }

        public void ChoseChimb_Checked(object sender, RoutedEventArgs e)
        {
            Habit.Visibility = Visibility.Hidden;
            ChoseEat.Visibility = Visibility.Hidden;
            ChoseShopping.Visibility = Visibility.Hidden;
            ChoseChimb.Visibility = Visibility.Hidden;
            ChoseSleep.Visibility = Visibility.Hidden;
            ChoseGender.Visibility = Visibility.Visible;
            Male.Visibility = Visibility.Visible;
            Female.Visibility = Visibility.Visible;
            Secret.Visibility = Visibility.Visible;
            ChoseGender.Content = "你希望你的第一個小孩的性別是";
            Str += "你的興趣：" + ChoseChimb.Content.ToString() + "、";
        }

        public void ChoseSleep_Checked(object sender, RoutedEventArgs e)
        {
            Habit.Visibility = Visibility.Hidden;
            ChoseEat.Visibility = Visibility.Hidden;
            ChoseShopping.Visibility = Visibility.Hidden;
            ChoseChimb.Visibility = Visibility.Hidden;
            ChoseSleep.Visibility = Visibility.Hidden;
            ChoseGender.Visibility = Visibility.Visible;
            Male.Visibility = Visibility.Visible;
            Female.Visibility = Visibility.Visible;
            Secret.Visibility = Visibility.Visible;
            ChoseGender.Content = "你覺得2016選總統是男生還是女生";
            Str += "你的興趣：" + ChoseSleep.Content.ToString() + "、";
        }

        public void Male_Checked(object sender, RoutedEventArgs e)
        {
            Male.Visibility = Visibility.Hidden;
            ChoseGender.Visibility = Visibility.Hidden;
            Female.Visibility = Visibility.Hidden;
            Secret.Visibility = Visibility.Hidden;
            ChoseInvestment.Visibility = Visibility.Visible;
            InvestYes.Visibility = Visibility.Visible;
            InvestNo.Visibility = Visibility.Visible;
            ChoseInvestment.Content = "你有存錢的習慣嗎";
            Str += ChoseGender.Content.ToString() + "：男、";
        }

        public void Female_Checked(object sender, RoutedEventArgs e)
        {
            Male.Visibility = Visibility.Hidden;
            ChoseGender.Visibility = Visibility.Hidden;
            Female.Visibility = Visibility.Hidden;
            Secret.Visibility = Visibility.Hidden;
            ChoseInvestment.Visibility = Visibility.Visible;
            InvestYes.Visibility = Visibility.Visible;
            InvestNo.Visibility = Visibility.Visible;
            ChoseInvestment.Content = "你有購物慾望嗎";
            Str += ChoseGender.Content.ToString() + "：女、";
        }

        public void Secret_Checked(object sender, RoutedEventArgs e)
        {
            Male.Visibility = Visibility.Hidden;
            ChoseGender.Visibility = Visibility.Hidden;
            Female.Visibility = Visibility.Hidden;
            Secret.Visibility = Visibility.Hidden;
            ChoseInvestment.Visibility = Visibility.Visible;
            InvestYes.Visibility = Visibility.Visible;
            InvestNo.Visibility = Visibility.Visible;
            ChoseInvestment.Content = "你有購物慾望嗎";
            Str += ChoseGender.Content.ToString() + "：不告訴你、";
        }

        private void InvestYes_Checked(object sender, RoutedEventArgs e)
        {
            ChoseInvestment.Visibility = Visibility.Hidden;
            InvestYes.Visibility = Visibility.Hidden;
            InvestNo.Visibility = Visibility.Hidden;
            Result.Visibility = Visibility.Visible;
            Answer.Visibility = Visibility.Visible;
            Str += ChoseInvestment.Content.ToString() + "：有。";
            Answer.Text = Str + "你是一個完美主義的人，凡事都希望追求完美，所以無形中會給自己造成不小壓力" +
            "，但也是因為如此，讓你在工作表上得到長官的賞識。";
        }

        private void InvestNo_Checked(object sender, RoutedEventArgs e)
        {
            ChoseInvestment.Visibility = Visibility.Hidden;
            InvestYes.Visibility = Visibility.Hidden;
            InvestNo.Visibility = Visibility.Hidden;
            Result.Visibility = Visibility.Visible;
            Answer.Visibility = Visibility.Visible;
            Str += ChoseInvestment.Content.ToString() + "：無。";
            Answer.Text = Str + "你是一個沒有理財習慣的人，所以你物慾很重，建議養成良好儲蓄習慣。";
        }
    }
}