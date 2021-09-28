using System;
using API.Data;
using API.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/livro")]
    public class LivroController : ControllerBase
    {
        private readonly DataContext _context;

        public LivroController(DataContext context)
        {
            _context = context;
        }
        
        // POST: api/livro/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
            return Created("", livro);
        }

        // GET: api/livro/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Livros.ToList());

    }
}