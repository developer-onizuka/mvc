﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Employee_without_DB.Models;
//using MongoDB.Bson;
//using MongoDB.Driver;
//using MongoDB.Bson.Serialization;

namespace Employee_without_DB.Controllers
{
    	public class HomeController : Controller
    	{
		private readonly ILogger<HomeController> _logger;
//    		private IMongoCollection<EmployeeEntity> collection;
		private static List<EmployeeEntity> _list = new List<EmployeeEntity>();

//    		public HomeController()
        	public HomeController(ILogger<HomeController> logger)
   		{
//			MongoClient client = new MongoClient("mongodb://127.0.0.1:27017");
//			IMongoDatabase db = client.GetDatabase("mydb");
//			collection = db.GetCollection<EmployeeEntity>("Employee");
//			this.collection = db.GetCollection<EmployeeEntity>("Employee");
//			IMongoCollection<EmployeeEntity> collection = db.GetCollection<EmployeeEntity>("Employee");

            		_logger = logger;
    		}

		public IActionResult Index()
		{
//			var model = collection.Find
//				(FilterDefinition<EmployeeEntity>.Empty).ToList();
//			var model = collection.Find(a=>true).ToList();
//			var model = new EmployeeEntity();
//			Console.WriteLine(list[0].EmployeeID);
//			Console.WriteLine(list[0].FirstName);
//			Console.WriteLine(list[0].LastName);
			var model = _list.FindAll(a=>true).ToList();
			return View(model);
		}

		[HttpGet]
		public IActionResult Insert()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Insert(EmployeeEntity emp)
		{
//			Console.WriteLine(emp.FirstName);
//			collection.InsertOne(emp);
//			ViewBag.Message = "Employee added successfully!";
			if (_list.Exists(x => x.EmployeeID == emp.EmployeeID))
			{
				ViewBag.Message = "The EmployeeID was already used.";
			}
			else
			{
				_list.Add(emp);
				ViewBag.Message = "Employee added successfully!";
			}
			return View();
		}

		[HttpGet]
//		public IActionResult Update(int id, string firstname, string lastname)
		public IActionResult Update(int id)
		{
//			ObjectId oId = new ObjectId(id);
//			Console.WriteLine(id);
//			EmployeeEntity emp = collection.Find(e => e.Id == oId).FirstOrDefault();
			EmployeeEntity emp = _list.Find(e => e.EmployeeID == id);
			return View(emp);
		}

		[HttpPost]
		public IActionResult Update(EmployeeEntity emp)
		{
//			emp.Id = new ObjectId(id);
//			Console.WriteLine(emp.Id);
//			var filter = Builders<EmployeeEntity>.Filter.Eq("Id", emp.Id);
//			var updateDef = Builders<EmployeeEntity>.Update.Set("FirstName", emp.FirstName);
//			updateDef = updateDef.Set("LastName", emp.LastName);
//			var updateDef = Builders<EmployeeEntity>.Update.Set("FirstName", emp.FirstName)
//								       .Set("LastName", emp.LastName);
//			var result = collection.UpdateOne(filter, updateDef);

//			if (result.IsAcknowledged)
//			{
//				ViewBag.Message = "Employee updated successfully!";
//			}
//			else
//			{
//				ViewBag.Message = "Error while updating Employee!";
//			}
			EmployeeEntity update = _list.Find(d => d.EmployeeID == emp.EmployeeID);
			int index = _list.IndexOf(update);
			_list.RemoveAt(index);
			_list.Insert(index, emp);	
			return View();
		}

//		public IActionResult ConfirmDelete(string id)
		public IActionResult ConfirmDelete(int id)
		{
//			ObjectId oId = new ObjectId(id);
//			EmployeeEntity emp = collection.Find(e => e.Id == oId).FirstOrDefault();
//			return View(emp);
			EmployeeEntity comfirmdel = _list.Find(c => c.EmployeeID == id);
			return View(comfirmdel);
		}

		[HttpPost]
//		public IActionResult Delete(string id)
		public IActionResult Delete(int id)
		{
//			ObjectId oId = new ObjectId(id);
//			var result = collection.DeleteOne<EmployeeEntity> (e => e.Id == oId);
//			if (result.IsAcknowledged)
//			{
//				TempData["Message"] = "Employee deleted successfully!";
//			}
//			else
//			{
//				TempData["Message"] = "Error while deleting Employee!";
//			}
//				return RedirectToAction("Index");
			EmployeeEntity del = _list.Find(d => d.EmployeeID == id);
			_list.Remove(del);
			return RedirectToAction("Index");
		}
	}
}
