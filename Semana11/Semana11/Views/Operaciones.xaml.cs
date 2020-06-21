using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Semana11.ViewModels;

namespace Semana11.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Operaciones : ContentPage
	{
		public Operaciones()
		{
			InitializeComponent();
			this.BindingContext = new OperacionesViewModel();
		}
	}
}
