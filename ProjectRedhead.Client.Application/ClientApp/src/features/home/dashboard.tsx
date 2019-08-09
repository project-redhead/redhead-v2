import React, { useState, useEffect } from 'react';

import UserApiService, { User } from '../../common/services/api/user';

import Card from '../../components/card';


const Dashboard = () => {

	const [user, setUser] = useState<User>({});
	useEffect(() => {
		UserApiService.getCurrentUser().then(u => setUser(u));
	}, []);

	return (
		<div>
			{user && <h1 className="header">Hey {user.displayName} 👋</h1>}

			<div className="row">
				<div className="col-md-6 col-sm-12">
					<Card>Test</Card>
				</div>
				<div className="col-md-6 col-sm-12">
					<Card>Test</Card>
				</div>
				<div className="col-md-6 col-sm-12">
					<Card>Test</Card>
				</div>
				<div className="col-md-6 col-sm-12">
					<Card>Test</Card>
				</div>
				<div className="col-md-6 col-sm-12">
					<Card>Test</Card>
				</div>
				<div className="col-md-6 col-sm-12">
					<Card>Test</Card>
				</div>
			</div>
		</div>
	);
};

export default Dashboard;
