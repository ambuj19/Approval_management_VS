using Approval_management.DataModel.DTO;
using Approval_management.DataModel.Entities;
using AutoMapper;

namespace Approval_management.Mapper
{
    public class ProfileMapper:Profile
    {
        public ProfileMapper()
        {
            CreateMap<UserInfo, UserInfoDto>().ReverseMap();
            CreateMap<RequestDetail, RequestDetailDto>().ReverseMap();
        }
    }
}
