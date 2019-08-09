import React from 'react';
import { BrowserRouter as Router, Route, Redirect, Switch } from "react-router-dom";
import AuthService from './common/services/auth';

import { LoginPage, LoginCallbackPage } from './features/auth';
import BetsOverviewPage from './features/betting/bets-overview-page';

import Dashboard from './features/home/dashboard';

const AppRouterSwitch = () => (
	<Switch>
		{/* Global pages */}
		{/* Login pages */}
		<Route path="/login/callback" component={LoginCallbackPage} />
		<Route exact path="/login" component={LoginPage} />

		{/* Private pages */}
		{/* Member pages */}
		{AuthService.isTokenValid() &&
			<>
				<Route exact path="/" component={Dashboard} />
				<Route path="/bets" component={BetsOverviewPage} />
			</> }

		{/* Misc */}
			{/* Redirect to login */}
		{!AuthService.isTokenValid() &&
			<Redirect exact path="/" to="/login" /> }
	</Switch>
);

export default AppRouterSwitch;
