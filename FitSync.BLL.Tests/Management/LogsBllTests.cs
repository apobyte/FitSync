using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.EntityFrameworkCore;
using FitSync.BLL._01.LogsManagement;
using FitSync.DAL._2.Context;

namespace FitSync.BLL.Tests.Management
{
    public class LogsBllTests
    {
        private static FitSyncDbContext CreateInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<FitSyncDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new FitSyncDbContext(options);
        }

        #region CreateLogAsync
        [Fact]
        public async Task CreateLogAsync_WithValidData_ReturnsTrueAndPersistedLog()
        {
            //---------------------------------------------------------------------------------------------------------------- Arrange
            await using var context = CreateInMemoryContext();
            var userId = Guid.NewGuid();
            var type = "TestLog";
            var bll = new LogsBll(context);
            //---------------------------------------------------------------------------------------------------------------- Act
            var result = await bll.CreateLogAsync(userId, type);
            //---------------------------------------------------------------------------------------------------------------- Assert
            result.Should().BeTrue();

            var persistedLog = await context.Logs.AsNoTracking().FirstOrDefaultAsync(u => u.UserId == userId && u.Type == type);
            using (new AssertionScope())
            {
                persistedLog.Should().NotBeNull();
                persistedLog!.UserId.Should().Be(userId);
                persistedLog.Type.Should().Be(type);
            }
        }
        #endregion
    }
}
