using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repo.Context;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TRBpkb : ControllerBase
{
    private readonly BpkbContext _ctx;

    public TRBpkb()
    {
        _ctx = new BpkbContext(new DbContextOptions<BpkbContext>());
    }

    [HttpGet]
    public async Task<IActionResult> Get() {
        try
        {
            var result = await _ctx.TrBpkbs.ToListAsync();
            return Ok(result);
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Repo.Domain.Models.TrBpkbCreateModel bpkbInfo) {
        try
        {
            if (bpkbInfo is null) throw new ArgumentNullException(nameof(bpkbInfo));
            var checkExistResult = await _ctx.TrBpkbs.AnyAsync(x => string.Equals(x.AgreementNumber, bpkbInfo.AgreementNumber));
            if (checkExistResult) throw new Exception("Can not add data with same aggremeent number.");

            var nBpkb = new Repo.Data.Entities.TrBpkb {
                AgreementNumber = bpkbInfo.AgreementNumber.ToUpper(),
                BpkbNo = bpkbInfo.BpkbNo?.ToUpper(),
                BranchId = bpkbInfo.BranchId?.ToUpper(),
                BpkbDate = bpkbInfo.BpkbDate,
                FakturNo = bpkbInfo.FakturNo?.ToUpper(),
                FakturDate = bpkbInfo.FakturDate,
                LocationId = bpkbInfo.LocationId?.ToUpper(),
                PoliceNo = bpkbInfo.PoliceNo?.ToUpper(),
                BpkbDateId = bpkbInfo.BpkbDateId
            };

            await _ctx.TrBpkbs.AddAsync(nBpkb);
            await _ctx.SaveChangesAsync();

            return Ok(nBpkb);
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }
    }    
}
