﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioLucasBackend.Hubconfig;
using DesafioLucasBackend.Model;
using DesafioLucasBackend.TimerFeatures;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace DesafioLucasBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private IHubContext<ChartHub> _hub;
        public ChartController(IHubContext<ChartHub> hub)
        {
            _hub = hub;
        }
        public IActionResult Get()
        {
            var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("transferchartdata", DataManager.GetData()));
            return Ok(new { Message = "Request Completed" });
        }
    }
}
