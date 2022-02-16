using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return  View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(string stringHeight, string stringLength, string stringWidth, string stringWeight)
    {
      int height = int.Parse(stringHeight);
      int length = int.Parse(stringLength);
      int width = int.Parse(stringWidth);
      int weight = int.Parse(stringWeight);

      Parcel package = new Parcel(height, length, width, weight);
      return RedirectToAction("Index");
    }
  }
}