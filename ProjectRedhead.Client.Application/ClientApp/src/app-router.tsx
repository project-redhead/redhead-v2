import React from 'react';
import { BrowserRouter, Route, Redirect } from "react-router-dom";

import { LoginPage, LoginCallbackPage } from './features/auth'

import AuthService from './common/services/auth';

const AppRouter = () => (
	<BrowserRouter>
		{/* Global pages */}
		<>
			{/* Login pages */}
			<Route exact path="/login" component={LoginPage} />
			<Route path="/login/callback" component={LoginCallbackPage} />
		</>

		{/* Private pages */}
		<>
			{/* Member pages */}
			{AuthService.isTokenValid() &&
				<Route exact path="/" component={() => <span>Hello</span>} />
			}
		</>

		{/* Misc */}
		<>
			{/* Redirect to login */}
			{!AuthService.isTokenValid() &&
				<Redirect path="/" to="/login" />
			}
		</>
	</BrowserRouter>
);

export default AppRouter;
