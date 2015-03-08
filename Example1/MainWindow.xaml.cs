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

namespace Example1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        AllControlCenter 熊大; 
        AllControlCenter 詹姆士; 
        AllControlCenter 鰻頭人;
        AllControlCenter 兔兔;

        public MainWindow()
        {
            InitializeComponent();
            熊大 = new AllControlCenter("熊大", 4500, 9);
            詹姆士 = new AllControlCenter("詹姆士", 5000, 10);
            鰻頭人 = new AllControlCenter("鰻頭人", 3000, 8);
            兔兔 = new AllControlCenter("兔兔", 8000, 12);
            熊大.RegisterObserver(詹姆士);
            熊大.RegisterObserver(鰻頭人);
            熊大.RegisterObserver(兔兔);
            詹姆士.RegisterObserver(熊大);
            詹姆士.RegisterObserver(鰻頭人);
            詹姆士.RegisterObserver(兔兔);
            鰻頭人.RegisterObserver(詹姆士);
            鰻頭人.RegisterObserver(熊大);
            鰻頭人.RegisterObserver(兔兔);
            兔兔.RegisterObserver(詹姆士);
            兔兔.RegisterObserver(鰻頭人);
            兔兔.RegisterObserver(熊大);
            firstPersonDataTextBlock.Text += "我是:" + 熊大.Name + "\n生命值:" + 熊大.HealthPoint + "\n等級:" + 熊大.Level;
            secondPersonDataTextBlock.Text += "我是:" + 詹姆士.Name + "\n生命值:" + 詹姆士.HealthPoint + "\n等級:" + 詹姆士.Level;
            thirdPersonDataTextBlock.Text += "我是:" + 鰻頭人.Name + "\n生命值:" + 鰻頭人.HealthPoint + "\n等級:" + 鰻頭人.Level;
            forthPersonDataTextBlock.Text += "我是:" + 兔兔.Name + "\n生命值:" + 兔兔.HealthPoint + "\n等級:" + 兔兔.Level;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            attchedTextBlock.Text = "";

            Random random = new Random();
            if (random.Next(0, 4) == 0)
            {
                if (熊大.HealthPoint > 0) 
                {
                    熊大.BeAttacked(random.Next(500, 1000));
                    attchedTextBlock.Text += "我是:" + 熊大.Name + "，我被攻擊了，" + 熊大.ObserverName + "，快來救我，我的生命值只剩" + 熊大.HealthPoint;
                }
            }
            else if (random.Next(0, 4) == 1)
            {
                if (詹姆士.HealthPoint > 0) 
                {
                    詹姆士.BeAttacked(random.Next(500, 1000));
                    attchedTextBlock.Text += "我是:" + 詹姆士.Name + "，我被攻擊了，" + 詹姆士.ObserverName + "，快來救我，我的生命值只剩" + 詹姆士.HealthPoint;
                }
            }
            else if (random.Next(0, 4) == 2)
            {
                if (鰻頭人.HealthPoint > 0) 
                {
                    鰻頭人.BeAttacked(random.Next(500, 1000));
                    attchedTextBlock.Text += "我是:" + 鰻頭人.Name + "，我被攻擊了，" + 鰻頭人.ObserverName + "，快來救我，我的生命值只剩" + 鰻頭人.HealthPoint;
                }
            }
            else
            {
                if (兔兔.HealthPoint > 0) 
                {
                    兔兔.BeAttacked(random.Next(500, 1000));
                    attchedTextBlock.Text += "我是:" + 兔兔.Name + "，我被攻擊了，" + 兔兔.ObserverName + "，快來救我，我的生命值只剩" + 兔兔.HealthPoint;
                }
            }

            firstPersonDataTextBlock.Text = "";
            secondPersonDataTextBlock.Text = "";
            thirdPersonDataTextBlock.Text = "";
            forthPersonDataTextBlock.Text = "";
           
            firstPersonDataTextBlock.Text += "我是:" + 熊大.Name + "\n生命值:" + 熊大.HealthPoint + "\n等級:" + 熊大.Level;
            secondPersonDataTextBlock.Text += "我是:" + 詹姆士.Name + "\n生命值:" + 詹姆士.HealthPoint + "\n等級:" + 詹姆士.Level;
            thirdPersonDataTextBlock.Text += "我是:" + 鰻頭人.Name + "\n生命值:" + 鰻頭人.HealthPoint + "\n等級:" + 鰻頭人.Level;
            forthPersonDataTextBlock.Text += "我是:" + 兔兔.Name + "\n生命值:" + 兔兔.HealthPoint + "\n等級:" + 兔兔.Level;
            /*
            熊大.BeAttacked(500);
            attchedTextBlock.Text += "我是:" + 熊大.Name + "我被攻擊了，" + 熊大.GetObserverPersonName() + "快來救我，我的生命值只剩" + 熊大.HealthPoint;
            */

        }
    }
}
