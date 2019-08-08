import React from 'react';
import Card from '../../components/card';

const Dashboard = () => {
	return (
		<div>
			<h1>Hey Gino 👋</h1>

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
