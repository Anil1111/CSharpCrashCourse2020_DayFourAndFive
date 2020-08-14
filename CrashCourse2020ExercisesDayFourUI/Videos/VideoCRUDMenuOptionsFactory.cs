using CrashCourse2020ExercisesDayFourUI.MenuAreas;
using CrashCourse2020ExercisesDayFourUI.Videos.Builders;

namespace CrashCourse2020ExercisesDayFourUI.Videos
{
    public class VideoCRUDMenuOptionsFactory: ICRUDMenuOptionsFactory
    {
        public IConsoleOutputBuilder GetOutputBuilder(CRUDMenuOptions option)
        {
            switch (option)
            {
                case CRUDMenuOptions.Create:
                {
                    var builder = new VideoCreateBuilder();
                    builder.CreateVideoData();
                    return builder;
                }
                case CRUDMenuOptions.ReadById:
                {
                    var builder = new VideoByIdBuilder();
                    builder.CreateVideoData();
                    return builder;
                }
                case CRUDMenuOptions.ReadAll:
                {
                    return new VideoPrintAllBuilder();
                }
                case CRUDMenuOptions.Update:
                {
                    var builder = new VideoUpdateBuilder();
                    builder.UpdateVideoData();
                    return builder;
                }
                case CRUDMenuOptions.Delete:
                {
                    var builder = new VideoDeleteBuilder();
                    builder.DeleteVideoData();
                    return builder;
                }
            }
            return null;
        }

        public IConsoleOutputBuilder GetMenu()
        {
            return new VideoMenuBuilder();
        }
    }
}