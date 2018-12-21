/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using Read.Users;
using System;
using Dolittle.ReadModels;

namespace Rules.Admin
{
    public class IsUserExistingRule : IRuleImplementationFor<Domain.Admin.Rules>
    {
        private readonly IReadModelRepositoryFor<User> _users;

        public IsUserExistingRule(IReadModelRepositoryFor<User> users)
        {
            _users = users; 
        }

        public Domain.Admin.Rules Rule => (Guid userId) =>
        {
            return _users.GetById(userId) != null;
        };
    }
}
