using Cajero.Models;
using Cajero.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IProductoRepository _productoRepository;
        public HomeController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public ViewResult Index()
        {
            //return View("ProductoList", ProductoRepository.responsesDto);
            return View("ProductoList", _productoRepository.Producto);
        }

        [HttpGet]
        public ViewResult ProductoAdd()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ProductoAdd(Producto productoResponse)
        {
            if (ModelState.IsValid)
            {
                _productoRepository.guardar(productoResponse);
                //return View("ProductoList", _productoRepository.Lista);
                return View("ProductoList", _productoRepository.Producto);
            } else
            {
                return View();
            }
        }
    }
}