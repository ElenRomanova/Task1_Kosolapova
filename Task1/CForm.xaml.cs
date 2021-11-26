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
using System.Windows.Shapes;


namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для CForm.xaml
    /// </summary>
    public partial class CForm : Window
    {
        public CForm()
        {
            InitializeComponent();
            CornerRadius cornerRadius = new CornerRadius(2);


            CForm cForm = (CForm)GetWindow(this);
            cForm.MinHeight = 380;
            cForm.MinWidth = 460;

         
            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();
            row1.Height = new GridLength(50, GridUnitType.Pixel);
            row2.Height = new GridLength(26, GridUnitType.Pixel);
            Table.RowDefinitions.Add(row1);
            Table.RowDefinitions.Add(new RowDefinition());
            Table.RowDefinitions.Add(row2);

 

            //шапка 
            Grid head = new Grid();
            Grid.SetRow(head, 0);
            Table.Children.Add(head);

            //создаем dockPanel 
            DockPanel dockPanel = new DockPanel();
            dockPanel.HorizontalAlignment = HorizontalAlignment.Left;
            head.Children.Add(dockPanel);

            //логотип
            Image logo = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("logo.jpg", UriKind.Relative);
            bi3.EndInit();
            logo.Source = bi3;
            logo.Height = head.Height;
            dockPanel.Children.Add(logo);

            //текст логотипа
            Label LableLogo = new Label();
            LableLogo.Content = "NBA Management System";
            LableLogo.VerticalAlignment = VerticalAlignment.Center;
            LableLogo.FontFamily = new FontFamily("Calibri");
            LableLogo.FontSize = 14;
            dockPanel.Children.Add(LableLogo);

            //название страницы
            Label LableAdmin = new Label();
            LableAdmin.Content = "Admin Login";
            LableAdmin.HorizontalAlignment = HorizontalAlignment.Center;
            LableAdmin.VerticalAlignment = VerticalAlignment.Center;
            LableAdmin.FontFamily = new FontFamily("Calibri");
            LableAdmin.FontSize = 16;
            head.Children.Add(LableAdmin);


            //Кнопка назад
            Button BtnBack = new Button();
            BtnBack.Content = "Back";
            BtnBack.HorizontalAlignment = HorizontalAlignment.Right;
            BtnBack.Height = 20;
            BtnBack.Width = 60;
            BtnBack.Margin = new Thickness(10);
            BtnBack.BorderThickness = new Thickness(2);
            BtnBack.BorderBrush = Brushes.LightGray;
            BtnBack.FontFamily = new FontFamily("Calibri");
            BtnBack.FontSize = 13;
            head.Children.Add(BtnBack);

            //граница
            Border border = new Border();
            border.BorderThickness = new Thickness(0, 0, 0, 1);
            border.BorderBrush = (Brush)(new BrushConverter().ConvertFrom("#6995c2"));
            Grid.SetRow(border, 0);
            Table.Children.Add(border);


            //тело страницы
            Grid body = new Grid();
            Grid.SetRow(body, 1);
            body.Height = 250;
            body.Width = 500;
            Table.Children.Add(body);


            for (int i = 0; i < 5; i++)
            {
                body.RowDefinitions.Add(new RowDefinition());
            }
            for (int j = 0; j < 3; j++)
            { body.ColumnDefinitions.Add(new ColumnDefinition()); }

            //текст формы
            Label LableBody = new Label();
            LableBody.Content = "Users can login into the system  using their jobnumber and password.";
            Grid.SetRow(LableBody, 0);
            Grid.SetColumn(LableBody, 0);
            Grid.SetColumnSpan(LableBody, 3);
            LableBody.HorizontalAlignment = HorizontalAlignment.Center;
            LableBody.VerticalAlignment = VerticalAlignment.Center;
            LableBody.FontFamily = new FontFamily("Calibri");
            LableBody.FontSize = 16;          
            LableBody.Margin = new Thickness(10);
            body.Children.Add(LableBody);


            //номер работника
            Label LableJobnumber = new Label();
            LableJobnumber.Content = "Jobnumber:";
            Grid.SetRow(LableJobnumber, 1);
            Grid.SetColumn(LableJobnumber, 0);
            LableJobnumber.FontFamily = new FontFamily("Microsoft Sans Serif");
            LableJobnumber.FontSize = 10;
            LableJobnumber.VerticalAlignment = VerticalAlignment.Center;
            LableJobnumber.HorizontalAlignment = HorizontalAlignment.Right;
            body.Children.Add(LableJobnumber);
            TextBox TxtBoxJobnumber = new TextBox();
            Grid.SetRow(TxtBoxJobnumber, 1);
            Grid.SetColumn(TxtBoxJobnumber, 1);
            Grid.SetColumnSpan(TxtBoxJobnumber, 2);
            TxtBoxJobnumber.VerticalAlignment = VerticalAlignment.Center;
            TxtBoxJobnumber.BorderThickness = new Thickness(1);
            TxtBoxJobnumber.BorderBrush = Brushes.LightGray;
            TxtBoxJobnumber.Height = 30;
            TxtBoxJobnumber.Width = 240;
            body.Children.Add(TxtBoxJobnumber);

            //пароль
            Label LablePassword = new Label();
            LablePassword.Content = "Password:";
            Grid.SetRow(LablePassword, 2);
            Grid.SetColumn(LablePassword, 0);
            LablePassword.FontFamily = new FontFamily("Microsoft Sans Serif");
            LablePassword.FontSize = 10;
            LablePassword.VerticalAlignment = VerticalAlignment.Center;
            LablePassword.HorizontalAlignment = HorizontalAlignment.Right;
            body.Children.Add(LablePassword);
            TextBox TextBoxPassword = new TextBox();
            Grid.SetRow(TextBoxPassword, 2);
            Grid.SetColumn(TextBoxPassword, 1);
            Grid.SetColumnSpan(TextBoxPassword, 2);
            TextBoxPassword.VerticalAlignment = VerticalAlignment.Center;
            TextBoxPassword.BorderThickness = new Thickness(1);
            TextBoxPassword.BorderBrush = Brushes.LightGray;
            TextBoxPassword.Height = 30;
            TextBoxPassword.Width = 240;
            body.Children.Add(TextBoxPassword);

            //чек-бокс
            CheckBox checkBox = new CheckBox();
            checkBox.Content = "Remember me";
            Grid.SetRow(checkBox, 3);
            Grid.SetColumn(checkBox, 1);
            LablePassword.FontFamily = new FontFamily("Microsoft Sans Serif");
            LablePassword.FontSize = 12;
            checkBox.Margin = new Thickness(45,10,10,10);
            checkBox.VerticalAlignment = VerticalAlignment.Top;
            checkBox.HorizontalAlignment = HorizontalAlignment.Left;
            body.Children.Add(checkBox);


            //войти
            Button BtnLogin = new Button();
            BtnLogin.Content = "Login";
            Grid.SetRow(BtnLogin, 4);
            Grid.SetColumn(BtnLogin, 1);
            BtnLogin.VerticalAlignment = VerticalAlignment.Center;
            BtnLogin.HorizontalAlignment = HorizontalAlignment.Left;
            BtnLogin.Width = 70;
            BtnLogin.Height = 30;
            BtnLogin.BorderThickness = new Thickness(2);
            BtnLogin.BorderBrush = Brushes.LightGray;
            BtnLogin.FontFamily = new FontFamily("Calibri");
            BtnLogin.FontSize = 13;
            BtnLogin.Margin = new Thickness(10, 0, 0, 0);
            body.Children.Add(BtnLogin);

            //кнопка очистки
            Button BtnCancel = new Button();
            BtnCancel.Content = "Cancel";
            Grid.SetRow(BtnCancel, 4);
            Grid.SetColumn(BtnCancel, 2);
            BtnCancel.VerticalAlignment = VerticalAlignment.Center;
            BtnCancel.HorizontalAlignment = HorizontalAlignment.Center;
            BtnCancel.BorderThickness = new Thickness(2);
            BtnCancel.BorderBrush = Brushes.LightGray;
            BtnCancel.FontFamily = new FontFamily("Calibri");
            BtnCancel.FontSize = 13;
            BtnCancel.Width = 70;
            BtnCancel.Height = 30;
            body.Children.Add(BtnCancel);

            //текст подвала
            Label textBlock = new Label();
            textBlock.Content = "The current season is 2016-2017, and the NBA already has a history of 71 years.";
            Grid.SetRow(textBlock, 2);
            textBlock.HorizontalContentAlignment = HorizontalAlignment.Center;
            textBlock.VerticalContentAlignment = VerticalAlignment.Center;
            textBlock.Background = (Brush)(new BrushConverter().ConvertFrom("#6995c2"));
            textBlock.Padding = new Thickness(50,0,0,0);
            textBlock.FontFamily = new FontFamily("Calibri");
            textBlock.FontSize = 13;
            textBlock.Foreground = Brushes.White;
            Table.Children.Add(textBlock);

        }
    }
}
