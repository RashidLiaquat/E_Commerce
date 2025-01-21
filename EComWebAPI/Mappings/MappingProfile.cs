using AutoMapper;
using EComDAL.DTOs;
using EComDAL.Model;

namespace EComWebAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Role, Roledto>().ReverseMap();
            CreateMap<User, Userdto>().ReverseMap();
            CreateMap<Province, Provincedto>().ReverseMap();
            CreateMap<Cart, Cartdto>().ReverseMap();
            CreateMap<CartItem, CartItemdto>().ReverseMap();
            CreateMap<Category, Categorydto>().ReverseMap();
            CreateMap<Country, Countrydto>().ReverseMap();
            CreateMap<Currency, Currencydto>().ReverseMap();
            CreateMap<Order, Orderdto>().ReverseMap();
            CreateMap<OrderItem, OrderItemdto>().ReverseMap();
            CreateMap<Payment, Paymentdto>().ReverseMap();
            CreateMap<Product, Productdto>().ReverseMap();
            CreateMap<SubCategory, SubCategorydto>().ReverseMap();
            CreateMap<AuditFields, AuditFieldsdto>().ReverseMap();


        }
    }
}
