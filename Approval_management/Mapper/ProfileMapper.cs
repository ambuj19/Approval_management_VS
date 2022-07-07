
using Approval_management.DataModel.Entities;
using Approval_management.ServiceModel.DTO.Request;
using Approval_management.ServiceModel.DTO.Response;
using AutoMapper;

namespace Approval_management.Mapper
{
    public class ProfileMapper:Profile
    {
        public ProfileMapper()
        {
            CreateMap<UserInfo, UserInfoDto>().ReverseMap();
            CreateMap<RequestDetail, RequestDetailDto>().ReverseMap();
            CreateMap<RequestDetail, RequestDetailResponseDto>().ReverseMap();
            CreateMap<RequestDetail, RequestAddDto>().ReverseMap();
            CreateMap<RequestDetail, RequestUpdateDto>().ReverseMap();
            CreateMap<RequestDetail, RequestUpdateResponse>().ReverseMap();
            CreateMap<RequestDetail, changeStatusDto>().ReverseMap();
            CreateMap<ForwordedRequestDetail, forwardDto>().ReverseMap();
            CreateMap<ForwordedRequestDetail, GetForwadedRequestDto>().ReverseMap();

        }
    }
}
