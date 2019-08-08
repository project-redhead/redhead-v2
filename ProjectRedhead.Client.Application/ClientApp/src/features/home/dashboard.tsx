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
			{user && <h1>Hey {user.displayName} 👋</h1>}

			<div className="grid-container">
				<div className="item w-4">
					<div className="gap">
						<Card>Test</Card>
					</div>
				</div>
				<div className="item w-4">
					<div className="gap">
						<Card>Test</Card>
					</div>
				</div>
				<div className="item w-4">
					<div className="gap">
						<Card>Test</Card>
					</div>
				</div>
				<div className="item w-4">
					<div className="gap">
						<Card>Test</Card>
					</div>
				</div>
				<div className="item w-4">
					<div className="gap">
						<Card>Test</Card>
					</div>
				</div>
				<div className="item w-4">
					<div className="gap">
						<Card>Test</Card>
					</div>
				</div>
			</div>
		</div>
	);
};

export default Dashboard;
