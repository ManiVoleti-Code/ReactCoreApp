using System;
using System.Threading;
using System.Threading.Tasks;
using AppDomain;
using AppPersistence;
using MediatR;

namespace AppBusiness.Activities
{
    public class Create
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }
            public string City { get; set; }
            public string Venue { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context) => _context = context;

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = new Activity();
                activity.Id = request.Id;
                activity.Title = request.Title;
                activity.Description = request.Description;
                activity.Date = request.Date;
                activity.City = request.City;
                activity.Venue = request.Venue;

                _context.Add(activity);
                var success = await _context.SaveChangesAsync() > 0;
                if (success)
                    return Unit.Value;

                throw new Exception("Problem in making a transcation");
            }
        }
    }
}