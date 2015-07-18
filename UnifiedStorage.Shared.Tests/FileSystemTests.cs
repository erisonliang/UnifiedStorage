﻿using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

// ReSharper disable once CheckNamespace

namespace UnifiedStorage.Shared.Tests
{
    public abstract class FileSystemTests
    {
        protected readonly IFileSystem FileSystem;

        protected FileSystemTests(IFileSystem fileSystem)
        {
            FileSystem = fileSystem;
        }

        [Test]
        public async Task Verify_that_LocalStorage_returns_an_existing_directory()
        {
            var directory = FileSystem.LocalStorage;

            directory.Should().NotBeNull();
            (await directory.ExistsAsync()).Should().BeTrue();
        }

        [Test]
        public async Task Verify_that_RoamingStorage_returns_an_existing_directory()
        {
            var directory = FileSystem.RoamingStorage;

            directory.Should().NotBeNull();
            (await directory.ExistsAsync()).Should().BeTrue();
        }

        [Test]
        public async Task Verify_that_TemporaryStorage_returns_an_existing_directory()
        {
            var directory = FileSystem.TemporaryStorage;

            directory.Should().NotBeNull();
            (await directory.ExistsAsync()).Should().BeTrue();
        }
    }
}