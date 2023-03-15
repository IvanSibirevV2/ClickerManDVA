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
///////////////////////////////////////////////



namespace ClickerManDVA_TestEr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// 1)меню настроек со временем частоты просмотра нажатости клавиш-
    /// 2)время задержки-
    /// 3)кнопки записи и исполнение для клавиатуры-
    /// 4)запись в массив объектов(каких то), содержут функцию конвертирования в строку и из строки, таймснап, актион,  
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}