using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using SPKTCore.Core;
using SPKTCore.Core.DataAccess;
using SPKTWeb.Friends.Interface;
using SPKTCore.Core.Impl;
using StructureMap;

namespace SPKTWeb.Friends.Presenter
{
    public class ShowFriendPresenter 
    {
        private IShowFriend _view;
        private IFriendRepository _friendRepository;
        private IUserSession _userSession;
        public ShowFriendPresenter()
        {
            _friendRepository = new SPKTCore.Core.DataAccess.Impl.FriendRepository();
            _userSession = new SPKTCore.Core.Impl.UserSession();
        }
        public void Init(IShowFriend view)
        {
            if (_userSession.LoggedIn)
            {
                _view = view;
                LoadFriend();
            }
        }

        public void LoadFriend()
        {
            _view.LoadFriend(_friendRepository.GetFriendsAccountsByAccountID(_userSession.CurrentUser.AccountID));
        }
    }
}