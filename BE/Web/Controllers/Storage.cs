using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repo.Context;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Storage : ControllerBase
{
    private readonly BpkbContext _ctx;

    public Storage()
    {
        _ctx = new BpkbContext(new DbContextOptions<BpkbContext>());
    }

    [HttpGet]
    public async Task<IActionResult> Get() {
        try
        {
            var result = await _ctx.MsStorageLocations.ToListAsync();
            return Ok(result);
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Repo.Domain.Models.MsStorageLocationCreateModel storageInfo) {
        try
        {
            if (storageInfo is null) throw new ArgumentNullException(nameof(storageInfo));
            var checkExistResult = await _ctx.MsStorageLocations.AnyAsync(x => string.Equals(x.LocationId, storageInfo.LocationId));
            if (checkExistResult) throw new Exception("Can not add storage location with same ID.");

            var nStorage = new Repo.Data.Entities.MsStorageLocation {
                LocationId = storageInfo.LocationId.ToUpper(),
                LocationName = storageInfo.LocationName?.ToUpper()
            };

            await _ctx.MsStorageLocations.AddAsync(nStorage);
            await _ctx.SaveChangesAsync();

            return Ok(nStorage);
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
