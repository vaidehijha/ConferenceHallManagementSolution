using DAL_ConferenceHallManagement.DbContexts;
using Repository_ConferenceHallManagement.AppDataRepositoy;
using Repository_ConferenceHallManagement.UtilityRepository;
namespace UoW_ConferenceHallManagement
{
    public interface IUnitOfWork : IDisposable
    {
        IMasterBookingStatusDataRepository MasterBookingStatusDataRepository { get; }
        IMasterRoomTypeDataRepository MasterRoomTypeDataRepository { get; }
        IMasterTempEmployeeRoleDataRepository MasterTempEmployeeRoleDataRepository { get; }
        ICHBookingSessionsDataRepository CHBookingSessionsDataRepository { get; }
        ICHSessionDataRepository CHSessionDataRepository { get; }
        IConferenceHallBookingDataRepository ConferenceHallBookingDataRepository { get; }
        IConferenceHallDataRepository ConferenceHallDataRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesEmpAsync();
        Task<int> SaveChangesAllAsync();
    }

    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ConferenceHallManagementContext _context;
        private readonly EmpdetContext _contextemp;

        public IMasterBookingStatusDataRepository MasterBookingStatusDataRepository { get; private set; }
        public IMasterRoomTypeDataRepository MasterRoomTypeDataRepository { get; private set; }
        public IMasterTempEmployeeRoleDataRepository MasterTempEmployeeRoleDataRepository { get; private set; }
        public ICHBookingSessionsDataRepository CHBookingSessionsDataRepository { get; private set; }
        public ICHSessionDataRepository CHSessionDataRepository { get; private set; }
        public IConferenceHallBookingDataRepository ConferenceHallBookingDataRepository { get; private set; }
        public IConferenceHallDataRepository ConferenceHallDataRepository { get; private set; }

        //employee repository
        public IEmployeeRepository EmployeeRepository { get; private set; }

        public UnitOfWork(ConferenceHallManagementContext context, EmpdetContext contextemp, IMasterBookingStatusDataRepository masterBookingStatusDataRepository, IMasterRoomTypeDataRepository masterRoomTypeDataRepository, IMasterTempEmployeeRoleDataRepository masterTempEmployeeRoleDataRepository, ICHBookingSessionsDataRepository cHBookingSessionsDataRepository, ICHSessionDataRepository cHSessionDataRepository, IConferenceHallBookingDataRepository conferenceHallBookingDataRepository, IConferenceHallDataRepository conferenceHallDataRepository, IEmployeeRepository employeeRepository)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context), "Context cannot be null");
            _contextemp = contextemp ?? throw new ArgumentNullException(nameof(contextemp), "Context cannot be null");
            MasterBookingStatusDataRepository = masterBookingStatusDataRepository;
            MasterRoomTypeDataRepository = masterRoomTypeDataRepository;
            MasterTempEmployeeRoleDataRepository = masterTempEmployeeRoleDataRepository;
            CHBookingSessionsDataRepository = cHBookingSessionsDataRepository;
            CHSessionDataRepository = cHSessionDataRepository;
            ConferenceHallBookingDataRepository = conferenceHallBookingDataRepository;
            ConferenceHallDataRepository = conferenceHallDataRepository;
            EmployeeRepository = employeeRepository;
        }
        

        public void Dispose()
        {
            _context?.Dispose();
            _contextemp?.Dispose();            
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<int> SaveChangesEmpAsync()
        {
            return await _contextemp.SaveChangesAsync();
        }
        public async Task<int> SaveChangesAllAsync()
        {
            await _context.SaveChangesAsync();
            await _contextemp.SaveChangesAsync();
            return 1;
        }
    }
}
