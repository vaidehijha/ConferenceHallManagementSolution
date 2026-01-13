using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models_ConferenceHallManagement.AppDbModels;
using DAL_ConferenceHallManagement.DbContexts;

namespace ConferenceHallManagement.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingStatusController : ControllerBase
    {
        private readonly ConferenceHallManagementContext _context;
        private readonly ILogger<BookingStatusController> _logger;

        public BookingStatusController(ConferenceHallManagementContext context, ILogger<BookingStatusController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/bookingstatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MasterBookingStatusCode>>> GetAll()
        {
            try
            {
                var statuses = await _context.MasterBookingStatusCodes
                    .Where(s => s.Status == true)
                    .ToListAsync();
                return Ok(statuses);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching booking statuses");
                return StatusCode(500, new { message = "Error fetching booking statuses", error = ex.Message });
            }
        }

        // GET: api/bookingstatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MasterBookingStatusCode>> GetById(int id)
        {
            try
            {
                var status = await _context.MasterBookingStatusCodes.FindAsync(id);
                if (status == null)
                {
                    return NotFound();
                }
                return Ok(status);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error fetching booking status with ID {id}");
                return StatusCode(500, new { message = "Error fetching booking status", error = ex.Message });
            }
        }

        // POST: api/bookingstatus
        [HttpPost]
        public async Task<ActionResult<MasterBookingStatusCode>> Create([FromBody] MasterBookingStatusCode status)
        {
            try
            {
                if (status == null)
                {
                    return BadRequest(new { message = "Status cannot be null" });
                }

                if (string.IsNullOrEmpty(status.StatusTextEn) || string.IsNullOrEmpty(status.StatusTextHi))
                {
                    return BadRequest(new { message = "StatusTextEn and StatusTextHi are required" });
                }

                // Get the next MasterBookingStatusId
                var maxStatusId = await _context.MasterBookingStatusCodes.MaxAsync(s => (int?)s.MasterBookingStatusId) ?? 0;
                status.MasterBookingStatusId = maxStatusId + 1;

                // Set default values
                status.Status = true;
                status.CreatedBy = "System";
                status.CreatedOn = DateTime.Now;
                status.CreatedFrom = "API";
                status.UpdatedBy = "System";
                status.UpdatedOn = DateTime.Now;
                status.UpdatedFrom = "API";

                _context.MasterBookingStatusCodes.Add(status);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetById), new { id = status.Id }, status);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating booking status");
                return StatusCode(500, new { message = "Error creating booking status", error = ex.Message });
            }
        }

        // PUT: api/bookingstatus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] MasterBookingStatusCode status)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { message = "Invalid ID" });
                }

                var existingStatus = await _context.MasterBookingStatusCodes.FindAsync(id);
                if (existingStatus == null)
                {
                    return NotFound();
                }

                existingStatus.StatusTextEn = status.StatusTextEn;
                existingStatus.StatusTextHi = status.StatusTextHi;
                existingStatus.UpdatedBy = "System";
                existingStatus.UpdatedOn = DateTime.Now;
                existingStatus.UpdatedFrom = "API";

                _context.MasterBookingStatusCodes.Update(existingStatus);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Status updated successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error updating booking status with ID {id}");
                return StatusCode(500, new { message = "Error updating booking status", error = ex.Message });
            }
        }

        // DELETE: api/bookingstatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { message = "Invalid ID" });
                }

                var status = await _context.MasterBookingStatusCodes.FindAsync(id);
                if (status == null)
                {
                    return NotFound();
                }

                // Soft delete - mark as inactive
                status.Status = false;
                status.UpdatedBy = "System";
                status.UpdatedOn = DateTime.Now;
                status.UpdatedFrom = "API";

                _context.MasterBookingStatusCodes.Update(status);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Status deleted successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error deleting booking status with ID {id}");
                return StatusCode(500, new { message = "Error deleting booking status", error = ex.Message });
            }
        }
    }
}
