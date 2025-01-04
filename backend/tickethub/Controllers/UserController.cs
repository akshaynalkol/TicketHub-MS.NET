using Microsoft.AspNetCore.Mvc;
using tickethub.DTO;
using tickethub.Services.Interfaces;


namespace tickethub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        // Constructor to inject IUserService
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        // Get all users
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var users = await userService.GetAsync();

            // Return status code 200 with users list
            return Ok(users);  
        }

        // Get user by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var user = await userService.GetByIdAsync(id);
            if (user == null)
            {
                // Return status code 404 if not found
                return NotFound(new { message = "User not found" }); 
            }
            // Return status code 200 with user object
            return Ok(user);  
        }

        // Authenticate user
        [HttpPost("authenticate")]
        public async Task<IActionResult> AuthenticateAsync([FromBody] LoginDTO loginDto)
        {
            var user = await userService.AuthenticateAsync(loginDto.Email, loginDto.Password);
            if (user == null)
            {
                // Return status code 401 if authentication fails
                return Unauthorized(new { message = "Invalid credentials" });  
            }
            // Return status code 200 with authenticated user data
            return Ok(user);  
        }

        // Add a new user
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] User user)
        {
            await userService.AddAsync(user);

            // Return status code 201 (Created)
            return CreatedAtAction(nameof(GetByIdAsync), new { id = user.Id }, new { message = "User Created Successfully" });  
        }

        // Update an existing user
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] User user)
        {
            if (id != user.Id)
            {
                // Return status code 400 if ID mismatch
                return BadRequest(new { message = "User ID mismatch" });  
            }

            var existingUser = await userService.GetByIdAsync(id);
            if (existingUser == null)
            {
                // Return status code 404 if user not found
                return NotFound(new { message = "User not found" });  
            }

            await userService.UpdateAsync(user);
            // Return status 200 on successful update
            return Ok(new { message = "User Updated Successfully" }); 
        }

        // Delete a user by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var user = await userService.GetByIdAsync(id);
            if (user == null)
            {
                // Return status code 404 if user not found
                return NotFound(new { message = "User not found" });  
            }

            await userService.DeleteAsync(id);
            // Return status 200 on successful update
            return Ok(new { message = "User Deleted Successfully" });
        }
    }
}
