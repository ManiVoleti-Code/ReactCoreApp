using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AppDomain;
using AppPersistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AppBusiness.Activities
{
    public class List
    {
        public class Query : IRequest<List<Activity>> { };

        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _context.Activities.ToListAsync();
                return result;
            }
        }
    }
}