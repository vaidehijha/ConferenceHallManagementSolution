using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models_ConferenceHallManagement.AppDbModels;
using DAL_ConferenceHallManagement.DbContexts;

namespace ConferenceHallManagement.api.Controllers
{
    [ApiController]
    [Route("api/room-type")]
    public class RoomTypeController : ControllerBase
    {
        private readonly ConferenceHallManagementContext _context;
        private readonly ILogger<RoomTypeController> _logger;

        public RoomTypeController(ConferenceHallManagementContext context, ILogger<RoomTypeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/room-type
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MasterRoomType>>> GetAll()
        {
            try
            {
                var roomTypes = await _context.MasterRoomTypes
                    .Where(r => r.Status == true)
                    .ToListAsync();
                return Ok(roomTypes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching room types");
                return StatusCode(500, new { message = "Error fetching room types", error = ex.Message });
            }
        }

        // GET: api/room-type/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MasterRoomType>> GetById(int id)
        {
            try
            {
                var roomType = await _context.MasterRoomTypes.FindAsync(id);
                if (roomType == null)
                {
                    return NotFound();
                }
                return Ok(roomType);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error fetching room type with ID {id}");
                return StatusCode(500, new { message = "Error fetching room type", error = ex.Message });
            }
        }

        // POST: api/room-type
        [HttpPost]
        public async Task<ActionResult<MasterRoomType>> Create([FromBody] MasterRoomType roomType)
        {
            try
            {
                if (roomType == null)
                {
                    return BadRequest(new { message = "Room type cannot be null" });
                }

                if (string.IsNullOrEmpty(roomType.RoomTypeEn) || string.IsNullOrEmpty(roomType.RoomTypeHi))
                {
                    return BadRequest(new { message = "RoomTypeEn and RoomTypeHi are required" });
                }

                // Get the next RoomTypeId
                var maxRoomTypeId = await _context.MasterRoomTypes.MaxAsync(r => (int?)r.RoomTypeId) ?? 0;
                roomType.RoomTypeId = maxRoomTypeId + 1;

                // Set default values
                roomType.Status = true;
                roomType.CreatedBy = "System";
                roomType.CreatedOn = DateTime.Now;
                roomType.CreatedFrom = "API";
                roomType.UpdatedBy = "System";
                roomType.UpdatedOn = DateTime.Now;
                roomType.UpdatedFrom = "API";

                _context.MasterRoomTypes.Add(roomType);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetById), new { id = roomType.Id }, roomType);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating room type");
                return StatusCode(500, new { message = "Error creating room type", error = ex.Message });
            }
        }

        // PUT: api/room-type/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] MasterRoomType roomType)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { message = "Invalid ID" });
                }

                var existingRoomType = await _context.MasterRoomTypes.FindAsync(id);
                if (existingRoomType == null)
                {
                    return NotFound();
                }

                existingRoomType.RoomTypeEn = roomType.RoomTypeEn;
                existingRoomType.RoomTypeHi = roomType.RoomTypeHi;
                existingRoomType.UpdatedBy = "System";
                existingRoomType.UpdatedOn = DateTime.Now;
                existingRoomType.UpdatedFrom = "API";

                _context.MasterRoomTypes.Update(existingRoomType);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Room type updated successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error updating room type with ID {id}");
                return StatusCode(500, new { message = "Error updating room type", error = ex.Message });
            }
        }

        // DELETE: api/room-type/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { message = "Invalid ID" });
                }

                var roomType = await _context.MasterRoomTypes.FindAsync(id);
                if (roomType == null)
                {
                    return NotFound();
                }

                // Soft delete - mark as inactive
                roomType.Status = false;
                roomType.UpdatedBy = "System";
                roomType.UpdatedOn = DateTime.Now;
                roomType.UpdatedFrom = "API";

                _context.MasterRoomTypes.Update(roomType);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Room type deleted successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error deleting room type with ID {id}");
                return StatusCode(500, new { message = "Error deleting room type", error = ex.Message });
            }
        }
    }
}
