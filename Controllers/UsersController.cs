using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartScript_NETCore.Controllers.Resources;
using SmartScript_NETCore.Data;
using SmartScript_NETCore.Models;

namespace SmartScript_NETCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : BaseApiController
    
    {
    private readonly DataContext context;
    private readonly IMapper mapper;
    public UsersController(DataContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;
    }

    [HttpGet("/api/users")]
    public async Task<IEnumerable<UserResource>> GetUsers()
    {
        var users = await context.Users
        .Include(u => u.Prescriptions)
            .ThenInclude(u => u.Drug)
                .ThenInclude(u => u.Ingredients)
                    .ThenInclude(u => u.Chemical)
                        .ThenInclude(u => u.Effects)
                            .ThenInclude(u => u.Variant)
                                .ThenInclude( u => u.UserVariants)
        .ToListAsync();

        return mapper.Map<List<User>, List<UserResource>>(users);
    }
    }
}