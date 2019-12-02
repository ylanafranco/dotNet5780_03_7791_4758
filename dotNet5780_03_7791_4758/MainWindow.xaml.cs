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

namespace dotNet5780_03_7791_4758
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Host currentHost;
        List<Host> hostsList = new List<Host>()
            {
                new Host()
                {
                    HostName = "Liam",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "Forest House",
                            Rooms = 2,
                            isSwimmingPool = false,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>() {
                                "https://cdn.pixabay.com/photo/2017/04/12/19/06/log-home-2225442_1280.jpg",
                                "https://i.pinimg.com/474x/41/e5/45/41e5451b251bd4b29fe55fac3eef0931.jpg",
                            "https://i.pinimg.com/474x/cf/10/9f/cf109f4ffab7a88cbd4ca9545ffa2b6e.jpg"}
                        },

                        new HostingUnit()
                        {
                            UnitName = "Wood House",
                            Rooms = 3,
                            isSwimmingPool = true,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>() {"https://i.pinimg.com/564x/73/87/9e/73879e4f35b452f30b9e90ae91c6f5dd.jpg",
                                "https://i.pinimg.com/474x/3d/5d/14/3d5d14b4a54b81063ef1b037d3232b1c.jpg",
                            "https://i.pinimg.com/474x/c4/84/c7/c484c76706da2f94833bf73eeac6e535.jpg",
                            "https://i.pinimg.com/474x/f3/96/02/f39602b7f45ad15397337b1e34b7c06b.jpg"}
                        },

                        new HostingUnit()
                        {
                            UnitName = "Tree House",
                            Rooms = 2,
                            isSwimmingPool = true,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>() { "https://i.pinimg.com/564x/42/37/9a/42379af6b4199099fb3e8aeac06f0ca4.jpg",
                            "https://i.pinimg.com/474x/a6/22/d7/a622d758d286c7fb5e4403f710a59e66.jpg",
                            "https://i.pinimg.com/474x/3b/cc/86/3bcc86144427d52a44b49def6e41016a.jpg"}
                        }
                    }
                },

                new Host()
                {
                    HostName = "Jo",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "Luxury House",
                            Rooms = 4,
                            isSwimmingPool = true,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>() { "https://i.pinimg.com/564x/7d/1c/9d/7d1c9d6ef8620f8e68ff42cd2b4657b1.jpg",
                            "https://i.pinimg.com/474x/f0/5d/c9/f05dc91ff9e748bf15d8087ef1ede4c2.jpg",
                            "https://i.pinimg.com/474x/4b/b7/37/4bb7374593c3b2263b42a9527e1f901d.jpg",
                            "https://i.pinimg.com/474x/4a/fc/cd/4afccd8fef4b651acf573469aa1189b1.jpg",
                            "https://i.pinimg.com/474x/b2/aa/34/b2aa34b6705a9695d2fd38bbe6ec4f12.jpg"}
                        },

                        new HostingUnit()
                        {
                            UnitName = "Design House",
                            Rooms = 5,
                            isSwimmingPool = false,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>() { "https://i.pinimg.com/564x/0a/df/77/0adf779f9a4ca2f1511b93449defa8fd.jpg",
                            "https://i.pinimg.com/474x/1c/ec/70/1cec702f4627561c16bf3dee48e9d0d4.jpg",
                            "https://i.pinimg.com/474x/ce/16/3d/ce163d15262fe3feed883ab1d12b8d55.jpg",
                            "https://i.pinimg.com/474x/b5/fd/e9/b5fde968dce95defeaef45a3b77e3bb9.jpg",
                            "https://i.pinimg.com/474x/db/8c/44/db8c449b87de68b205347d07c2cfa143.jpg",
                            "https://i.pinimg.com/474x/1f/98/a4/1f98a474809a79cbcdbca638c83cdb05.jpg"}
                        }

                    }
                },

                new Host()
                {
                    HostName = "Dean",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "Barbie World",
                            Rooms = 1,
                            isSwimmingPool = false,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>() { "https://i.pinimg.com/564x/62/1b/dc/621bdc23f914020c27903e3002405d5c.jpg",
                            "https://i.pinimg.com/474x/8b/4c/52/8b4c52978d699558883ccfaca87cfb19.jpg"}
                        },

                        new HostingUnit()
                        {
                            UnitName = "Swimming Loft",
                            Rooms = 1,
                            isSwimmingPool = true,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>() {"https://i.pinimg.com/564x/39/7c/ec/397cec2d404a7c5cade6a7a0dfdf9704.jpg",
                            "https://i.pinimg.com/474x/b4/0f/b3/b40fb30ac7519319d9e13a2c55da7c74.jpg",
                            "https://i.pinimg.com/474x/29/9e/1f/299e1ff6c902fcd3c85f041abdcd793d.jpg"}
                        }

                    }
                }

            };

        public MainWindow()
        {
            InitializeComponent();
            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;
        }

        private void cbHostList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeHost(cbHostList.SelectedIndex);
        }

        private void InitializeHost(int index)
        {
            MainGrid.Children.RemoveRange(1, 3);
            currentHost = hostsList[index];
            UpGrid.DataContext = currentHost;
            for (int i = 0; i < currentHost.Units.Count; i++)
            {
                HostingUnitUserControl a = new HostingUnitUserControl(currentHost.Units[i]);
                MainGrid.Children.Add(a);
                Grid.SetRow(a, i + 1);
            }
        }

    }
}
