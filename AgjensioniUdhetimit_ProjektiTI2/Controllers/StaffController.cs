﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using AgjensioniUdhetimit_ProjektiTI2.Models;
using AgjensioniUdhetimit_ProjektiTI2.Services;

namespace AgjensioniUdhetimit_ProjektiTI2.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Staff/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        StaffService staffService;

        public StaffController()
        {
            staffService = new StaffService();
        }

        public DataTable ShowStaff()
        {
            return staffService.GetStaff();
        }
        public bool CreateStaff(Staff staff)
        {
            return staffService.InsertStaff(staff);
        }

        // get item by id
        public Staff GetStaffByID(int id)
        {
            return staffService.GetItemById(id);
        }

        public bool DeleteStaff(int id)
        {
            return staffService.DeleteStaff(id);
        }

        public bool UpdateStaf(Staff staff)
        {
            return staffService.EditStaff(staff);
        }


    }
}