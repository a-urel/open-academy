using OpenAcademy.MongoDB;
using OpenAcademy.Samples;
using Xunit;

namespace OpenAcademy.MongoDb.Applications;

[Collection(OpenAcademyTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<OpenAcademyMongoDbTestModule>
{

}
