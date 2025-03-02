using OpenAcademy.Samples;
using Xunit;

namespace OpenAcademy.MongoDB.Domains;

[Collection(OpenAcademyTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<OpenAcademyMongoDbTestModule>
{

}
