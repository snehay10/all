using firstCrud.Data;
using firstCrud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace firstCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext _productDbContext;

        public ProductController(ProductDbContext context)
        {
            _productDbContext = context;
        }

        //read
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var product = _productDbContext.Products.ToList();
                if (product.Count == 0)
                {
                    return NotFound("Product not found...");
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //get data by id which is pass by the user
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var products = _productDbContext.Products.Find(id);
                if (products == null)
                {
                    return NotFound("id not available");
                }
                return Ok(products);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        //insert data

        [HttpPost]
        public IActionResult Add(product model)
        {
            try
            {
                _productDbContext.Products.Add(model);
                _productDbContext.SaveChanges();
                return Ok("Product inserted");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //data update
        [HttpPut]
        public IActionResult Put(product model)
        {
            try
            {
                if (model == null || model.Id == 0)
                {
                    if (model == null)
                    {
                        return BadRequest("Model id is invalide");
                    }
                    else
                    {
                        return BadRequest("product id never 0");
                    }
                }
                var product = _productDbContext.Products.Find(model.Id);
                if (product == null)
                {
                    return BadRequest("product not found with id");
                }
                product.ProductName = model.ProductName;
                product.Price = model.Price;
                product.Qty = model.Qty;
                _productDbContext.SaveChanges();
                return Ok("product updated");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        //data delete
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var product = _productDbContext.Products.Find(id);
                if (product == null)
                {
                    return BadRequest("product with id not present");
                }
                _productDbContext.Products.Remove(product);
                _productDbContext.SaveChanges();
                return Ok("product deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
