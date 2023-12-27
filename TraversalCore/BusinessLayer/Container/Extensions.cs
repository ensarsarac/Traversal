using BusinessLayer.Abstract;
using BusinessLayer.Abstract.AbstractUow;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.UowConcrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.AnnouncementDTOs;
using DTOLayer.ContactDTOs;
using DTOLayer.DestinatonDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentRepository>();


            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();


            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationRepository>();

            services.AddScoped<IGuideService, GuidesManager>();
            services.AddScoped<IGuideDal, EfGuideRepository>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal,EfContactRepository>();

            services.AddScoped<IWriteUsService, WriteUsManager>();
            services.AddScoped<IWriteUsDal,EfWriteUsRepository>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAccouncementRepository>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountRepository>();

            services.AddScoped<IUowDal, UowDal>();

        }


        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAdd>, AnnouncementValidator>();
            services.AddTransient<IValidator<DestinationAddDTO>, DestinationAddDTOValidator>();
            services.AddTransient<IValidator<AnnouncementUpdateDto>, AnnouncementUpdateValidator>();
            services.AddTransient<IValidator<WriteUsDTO>, WriteUsValidator>();

        }
    }
}
