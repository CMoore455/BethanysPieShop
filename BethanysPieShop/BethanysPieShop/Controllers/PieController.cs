using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Controllers
{
	public class PieController : Controller
	{
		private readonly IPieRepository pieRepository;
		private readonly ICategoryRepository categoryRepository;

		public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
		{
			this.pieRepository = pieRepository;
			this.categoryRepository = categoryRepository;
		}

		public IActionResult List()
		{
			PiesListViewModel piesListViewModel = new PiesListViewModel();
			piesListViewModel.Pies = pieRepository.AllPies;

			piesListViewModel.CurrentCategory = "Chesse Cakes";
			return View(piesListViewModel);
		}
	}
}
