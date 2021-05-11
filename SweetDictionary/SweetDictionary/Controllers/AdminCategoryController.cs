using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetDictionary.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryValues = categoryManager.GetList();
            return View(categoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            CategoryValidation categoryValidator = new CategoryValidation();
            ValidationResult result = categoryValidator.Validate(c);
            if(result.IsValid)
            {
                categoryManager.CategoryAdd(c);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }

        public ActionResult DeleteCategory(int id)
        {
            var categoryValue = categoryManager.GetById(id);
            categoryManager.CategoryDelete(categoryValue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var categoryValue = categoryManager.GetById(id);
            return View(categoryValue);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category c)
        {
            categoryManager.CategoryUpdate(c);
            return RedirectToAction("Index");
        }
    }
}