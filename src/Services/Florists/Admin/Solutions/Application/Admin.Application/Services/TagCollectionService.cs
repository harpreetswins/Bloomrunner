using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Services
{
    public class TagCollectionService : ITagCollectionService
    {
        private readonly ITagCollectionRepository _tagCollectionRepository;
        public TagCollectionService(ITagCollectionRepository tagCollectionRepository)
        {
            _tagCollectionRepository = tagCollectionRepository;
        }
        public async Task<IEnumerable<TagCollectionGridResponse>> GetTagCollectionGridLists(TagCollectionGridModel tagCollectionGridModel)
        {
            return await _tagCollectionRepository.GetTagCollectionGridLists(tagCollectionGridModel);
        }
        public async Task<IEnumerable<TagCollectionModel>> GetTagCollectionList()
        {
            return await _tagCollectionRepository.GetTagCollectionList();
        }
        public async Task<IEnumerable<TagCollectionModel>> GetTagCollectionList(string TagCollectionName)
        {
            return await _tagCollectionRepository.GetTagCollectionList(TagCollectionName);
        }
        public async Task<IEnumerable<TagGridListDrivedModel>> GetTagGridLists(TagGridListModel tagGridListModel)
        {
            return await _tagCollectionRepository.GetTagGridLists(tagGridListModel);
        }
    }
}