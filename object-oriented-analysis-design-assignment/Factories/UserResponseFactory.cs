namespace object_oriented_analysis_design_assignment.Factories;
using object_oriented_analysis_design_assignment.Models.Dtos;

public class UserResponseFactory
{
    public static UserResponse Create()
    {
        return new UserResponse();
    }
}
