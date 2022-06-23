
using Approval_management.DataModel.Entities;
using Approval_management.ServiceModel.DTO.Request;
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
