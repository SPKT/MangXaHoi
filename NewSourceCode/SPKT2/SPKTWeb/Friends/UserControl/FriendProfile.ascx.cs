﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using SPKTCore.Core.Domain;
using SPKTWeb.Friends.Interface;
using SPKTWeb.Friends.Presenter;
using SPKTCore.Core.DataAccess.Impl;
using SPKTCore.Core.DataAccess;
using SPKTCore.Core.Impl;

namespace SPKTWeb.Friends
{
    public partial class FriendProfile : System.Web.UI.UserControl,IProfileDisplay
    {
        private ProfileDisplayPresenter _presenter;
        protected Account _account;
        protected Profile _profile;
        protected AccountRepository _ac;
        protected UserSession _usersession;
        protected IFriendInvitationRepository _fi;
        protected IFriendRepository _f;
        protected void Page_Load(object sender, EventArgs e)
        {
            _usersession = new SPKTCore.Core.Impl.UserSession();
            _fi = new SPKTCore.Core.DataAccess.Impl.FriendInvitationRepository();
            _f = new SPKTCore.Core.DataAccess.Impl.FriendRepository();
            _presenter = new ProfileDisplayPresenter();
            _presenter.Init(this);
            btn_de.Attributes.Add("onclick", "javascript:return confirm('Ban co muon xoa bạn?')");
            if (_usersession.CurrentUser == null)
            {
                btn_add_de.Visible = true;
                btn_de.Visible = false;
            }
            else
            {
                if (_presenter.TestFriend(_account) == true||_presenter.TestFriend2(_account))
                {
                    btn_add_de.Visible = false;
                    btn_de.Visible = true;
                }
                else
                {
                    btn_add_de.Visible = true;
                    btn_de.Visible = false;
                }
            }
        }
        
        public bool ShowDeleteButton
        {
            set
            {
                btn_de.Visible = value;
            }
        }

        public bool ShowFriendRequestButton
        {
            set
            {
                btn_add_de.Visible = value;
            }
        }
        public void LoadDisplay(Account account)
        {
            _ac = new SPKTCore.Core.DataAccess.Impl.AccountRepository();
            _account = account;
            //_profile = profile;
            //ibInviteFriend.Attributes.Add("FriendsID", _account.AccountID.ToString());
            //ibDelete.Attributes.Add("FriendsID", _account.AccountID.ToString());
            //litAccountID.Text = account.AccountID.ToString();
           // if (_profile.FullName == null)



            lblName.Text = _ac.fullname(account.AccountID);
            lblUsername.Text = account.UserName;
            lblCreateDate.Text = account.CreateDate.ToString();
            //lblName.Text = account.Email;
            //lblCreateDate.Text = account.CreateDate.ToString();
            //imgAvatar.ImageUrl += "?AccountID=" + account.AccountID.ToString();
            //lblUsername.Text = account.UserName;
            lblFriendID.Text = account.AccountID.ToString();
        }

        protected void lbInviteFriend_Click(object sender, EventArgs e)
        {
            _presenter = new ProfileDisplayPresenter();
            _presenter.Init(this);
            _presenter.SendFriendRequest(Convert.ToInt32(lblFriendID.Text));
        }

        protected void btn_de_Click(object sender, EventArgs e)
        {
            _presenter = new ProfileDisplayPresenter();
            _presenter.Init(this);
            _presenter.DeleteFriend(Convert.ToInt32(lblFriendID.Text));
        }

        protected void btn_add_de_Click(object sender, EventArgs e)
        {
            _presenter = new ProfileDisplayPresenter();
            _presenter.Init(this);
            _presenter.SendFriendRequest(Convert.ToInt32(lblFriendID.Text));
        }
    }
}