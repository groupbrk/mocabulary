﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EnglishHubRepository
{
    public interface IWordRepository
    {
         Task<List<WordEntity>> GetAll();
         Task<WordEntity> Get(string id);
         Task<WordEntity> Add(WordEntity entity);

         Task<bool> Remove(string id);

         Task<bool> Update(WordEntity entity);

         Task<bool> RemoveAll();

         Task<List<WordEntity>> GetWordsByUserId(string userId);

         Task<List<PackageEntity>> GetPackagesByUserId(string userId);

         Task<PackageEntity> AddPackage(PackageEntity entity);
    }
}
