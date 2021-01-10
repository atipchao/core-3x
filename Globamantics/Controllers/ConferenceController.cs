using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Globamantics.Services;
using Microsoft.AspNetCore.Mvc;

namespace Globamantics.Controllers
{
    public class ConferenceController : Controller
    {
        public ConferenceController(IConferenceService conferenceService)
        {

        }
    } 
}