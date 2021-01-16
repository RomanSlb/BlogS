﻿using BlogS.Data.Models;
using BlogS.Models.PostViewModels;
using BlogS.Models.HomeViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogS.BusinessManagers.Interfaces
{
    public interface IPostBusinessManager
    {
        IndexViewModel GetIndexViewModel(string searchString, int? page);
        Task<ActionResult<PostViewModel>>GetPostViewModel(int? id, ClaimsPrincipal claimsPrincipal);
        Task<Post> CreatePost(CreateViewModel createViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<Comment>> CreateComment(PostViewModel postViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> UpdatePost(EditViewModel editViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> GetEditViewModel(int? id, ClaimsPrincipal claimsPrincipal);
    }
}
