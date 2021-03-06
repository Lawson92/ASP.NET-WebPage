using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GithubEmojis.Pages
{
    public class IndexModel : PageModel
    {
        private IGithubEmojiService _emojiService;
        public IndexModel(IGithubEmojiService emojiSvc){
            _emojiService = emojiSvc;
            }

    public IList<Emoji> Emojis
    {
        get;
        set;
    }


        

        public async Task OnGet()
        {
        Emojis = await _emojiService.GetEmojis();
        }
    }
}
