using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using TraversalCore.Areas.Admin.Models;
using System.Net.Http.Headers;

namespace TraversalCore.Areas.Admin.Controllers

{
    [Area("Admin")]

    public class ApiHotelController : Controller
    {
        public async Task<IActionResult> Index()
        {

			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?units=metric&locale=en-gb&checkin_date=2024-05-19&dest_type=city&order_by=popularity&filter_by_currency=EUR&adults_number=2&room_number=1&dest_id=-1456928&checkout_date=2024-05-20&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&children_ages=5%2C0&children_number=2"),
				Headers =
	{
		{ "X-RapidAPI-Key", "993ab9c561msh7beed076fa1064ap1dae43jsnd1ee335b10e2" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ApiHotelViewModel>(body);
				return View(values.results);
			}
		}


		[HttpGet]
		public IActionResult GetByIdCity()
        {
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> GetByIdCity(string search)
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={search}&locale=en-gb"),
				Headers =
	{
		{ "X-RapidAPI-Key", "993ab9c561msh7beed076fa1064ap1dae43jsnd1ee335b10e2" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				
				return View();

			}
		}


	}
}
