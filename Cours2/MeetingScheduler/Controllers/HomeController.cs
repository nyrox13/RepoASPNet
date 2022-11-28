using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeetingScheduler.Models;
using Microsoft.AspNetCore.DataProtection.Repositories;
using MeetingScheduler.Persistance;

namespace MeetingScheduler.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() { 
        return View(); 
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
        if (ModelState.IsValid)
        {
            ResponsesRepository.AddResponse(guestResponse);
            return View("Merci", guestResponse);
        }
        else
        {
            return View();
        }
    }

    public ViewResult ListResponses()
    {
        return View(ResponsesRepository.Responses.Where(r => r.Participera == true));
    }
}
