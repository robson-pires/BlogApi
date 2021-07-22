using Microsoft.AspNetCore.Mvc;
using BlogApi.Repositories;
using System.Threading.Tasks;
using BlogApi.Models;
using BlogApi.Dtos;
using System.Collections.Generic;
using System;

namespace BlogApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        public PostsController(IPostRepository postRepository) 
        {
            _postRepository = postRepository;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetPost(int id)
        {
            var post = await _postRepository.Get(id);
            if (post == null)
                return NotFound();
            
            return Ok(post);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            var posts = await _postRepository.GetAll();
            if (posts == null)
                return NotFound();
            
            return Ok(posts);
        }

        [HttpPost]
        public async Task<ActionResult> CreatePost(CreatePostDto createPostDto) 
        {
            Post post = new()
            {
                Title = createPostDto.Title,
                Text = createPostDto.Text,
                CreatedBy = createPostDto.CreatedBy,
                CreatedOn = DateTime.Now
            };

            await _postRepository.Add(post);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeletePost(int id)
        {
            await _postRepository.Delete(id);
            return Ok();
        }
    }
}